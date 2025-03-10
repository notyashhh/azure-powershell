﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Storage.File
{
    using global::Azure;
    using global::Azure.Core;
    using global::Azure.Storage.Files.Shares;
    using global::Azure.Storage.Files.Shares.Models;
    using Microsoft.Azure.Storage.Blob;
    using Microsoft.Azure.Storage.File;
    using Microsoft.WindowsAzure.Commands.Common;
    using Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel;
    using Microsoft.WindowsAzure.Commands.Storage.Common;
    using Microsoft.WindowsAzure.Commands.Storage.Model.Contract;
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;

    public abstract class AzureStorageFileCmdletBase : StorageCloudCmdletBase<IStorageFileManagement>
    {
        [Parameter(Mandatory = false, HelpMessage = "Disallow trailing dot (.) to suffix directory and file names.", ParameterSetName = Constants.ShareNameParameterSetName)]
        public virtual SwitchParameter DisAllowTrailingDot { get; set; }
        protected FileRequestOptions RequestOptions
        {
            get
            {
                return (FileRequestOptions)this.GetRequestOptions(StorageServiceType.File);
            }
        }

        protected override IStorageFileManagement CreateChannel()
        {
            if (this.Channel == null || !this.ShareChannel)
            {
                try
                {
                    this.Channel = new StorageFileManagement(
                            this.GetCmdletStorageContext(outputErrorMessage: false)
                    );
                }
                catch (InvalidOperationException)
                {
                    this.Channel = new StorageFileManagement(
                        AzureStorageContext.EmptyContextInstance
                    );
                }
            }

            return this.Channel;
        }

        protected CloudFileShare BuildFileShareObjectFromName(string name)
        {
            NamingUtil.ValidateShareName(name, false);
            return this.Channel.GetShareReference(name);
        }

        protected bool ShareIsEmpty(ShareClient share)
        {
            try
            {
                ShareDirectoryGetFilesAndDirectoriesOptions listFileOptions = new ShareDirectoryGetFilesAndDirectoriesOptions();
                listFileOptions.Traits = ShareFileTraits.All;

                Pageable<ShareFileItem> fileItems = share.GetRootDirectoryClient().GetFilesAndDirectories(listFileOptions, this.CmdletCancellationToken);
                IEnumerable<Page<ShareFileItem>> fileitempages = fileItems.AsPages(null, 1);

                foreach (var page in fileitempages)
                {
                    foreach (var file in page.Values)
                    {
                        return false;

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ShareClientOptions ClientOptions
        {
            get
            {
                if (clientOptions == null)
                {
                    clientOptions = createClientOptions();
                    return clientOptions;
                }
                else
                {
                    return clientOptions;
                }
            }
        }
        private ShareClientOptions clientOptions = null;

        public ShareClientOptions createClientOptions()
        {
            ShareClientOptions clientOptions = new ShareClientOptions();
            clientOptions.AddPolicy(new UserAgentPolicy(ApiConstants.UserAgentHeaderValue), HttpPipelinePosition.PerCall);
            if (this.DisAllowTrailingDot.IsPresent)
            {
                clientOptions.AllowTrailingDot = false;
            }
            else
            {
                clientOptions.AllowTrailingDot = true;
            }
            clientOptions.AllowSourceTrailingDot = true;
            return clientOptions;
        }

        protected bool WithOauthCredential()
        {
            if(this.Channel != null && this.Channel.StorageContext != null && this.Channel.StorageContext.StorageAccount != null && this.Channel.StorageContext.StorageAccount.Credentials.IsToken)
            {
                return true;
            }
            return false;
        }

        protected void CheckContextForObjectInput(AzureStorageContext context)
        {
            if (context == null)
            {
                throw new InvalidOperationException("Could not get the storage context. Please pass in a storage context with \"-Context\" parameter (can be created with New-AzStorageContext cmdlet), " +
                            "or set the current storage context with Set-AzCurrentStorageAccount cmdlet.");
            }
        }
    }
}
