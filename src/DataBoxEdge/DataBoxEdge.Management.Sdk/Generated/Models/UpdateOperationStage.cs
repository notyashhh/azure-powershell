// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{

    /// <summary>
    /// Defines values for UpdateOperationStage.
    /// </summary>


    public static class UpdateOperationStage
    {
        public const string Unknown = "Unknown";
        public const string Initial = "Initial";
        public const string ScanStarted = "ScanStarted";
        public const string ScanComplete = "ScanComplete";
        public const string ScanFailed = "ScanFailed";
        public const string DownloadStarted = "DownloadStarted";
        public const string DownloadComplete = "DownloadComplete";
        public const string DownloadFailed = "DownloadFailed";
        public const string InstallStarted = "InstallStarted";
        public const string InstallComplete = "InstallComplete";
        public const string InstallFailed = "InstallFailed";
        public const string RebootInitiated = "RebootInitiated";
        public const string Success = "Success";
        public const string Failure = "Failure";
        public const string RescanStarted = "RescanStarted";
        public const string RescanComplete = "RescanComplete";
        public const string RescanFailed = "RescanFailed";
    }
}