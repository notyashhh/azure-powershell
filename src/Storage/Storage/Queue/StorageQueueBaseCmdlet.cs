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
// ---------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Storage.Common
{
    using Microsoft.WindowsAzure.Commands.Storage.Model.Contract;
    using global::Azure.Storage.Queues;
    using global::Azure.Core;
    using Microsoft.WindowsAzure.Commands.Common;

    /// <summary>
    /// base class for azure queue cmdlet
    /// </summary>
    public class StorageQueueBaseCmdlet : StorageCloudCmdletBase<IStorageQueueManagement>
    {
        //Overwrite the useless parameter
        public override int? ServerTimeoutPerRequest { get; set; }
        public override int? ClientTimeoutPerRequest { get; set; }
        public override int? ConcurrentTaskCount { get; set; }

        /// <summary>
        /// create queue service management channel.
        /// </summary>
        /// <returns>IStorageQueueManagement object</returns>
        protected override IStorageQueueManagement CreateChannel()
        {
            //init storage blob management channel
            if (Channel == null || !ShareChannel)
            {
                Channel = new StorageQueueManagement(GetCmdletStorageContext());
            }

            return Channel;
        }

        public QueueClientOptions ClientOptions
        {
            get
            {
                if (clientOptions == null)
                {
                    clientOptions = new QueueClientOptions();
                    clientOptions.AddPolicy(new UserAgentPolicy(ApiConstants.UserAgentHeaderValue), HttpPipelinePosition.PerCall); 
                }
                return clientOptions;
            }
        }
        private QueueClientOptions clientOptions = null;
    }
}
