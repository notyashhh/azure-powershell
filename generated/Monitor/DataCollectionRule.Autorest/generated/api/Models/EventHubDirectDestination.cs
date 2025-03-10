// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    public partial class EventHubDirectDestination :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IEventHubDirectDestination,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IEventHubDirectDestinationInternal
    {

        /// <summary>Backing field for <see cref="EventHubResourceId" /> property.</summary>
        private string _eventHubResourceId;

        /// <summary>The resource ID of the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string EventHubResourceId { get => this._eventHubResourceId; set => this._eventHubResourceId = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="EventHubDirectDestination" /> instance.</summary>
        public EventHubDirectDestination()
        {

        }
    }
    public partial interface IEventHubDirectDestination :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable
    {
        /// <summary>The resource ID of the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource ID of the event hub.",
        SerializedName = @"eventHubResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubResourceId { get; set; }
        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A friendly name for the destination.
        This name should be unique across all destinations (regardless of type) within the data collection rule.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    internal partial interface IEventHubDirectDestinationInternal

    {
        /// <summary>The resource ID of the event hub.</summary>
        string EventHubResourceId { get; set; }
        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        string Name { get; set; }

    }
}