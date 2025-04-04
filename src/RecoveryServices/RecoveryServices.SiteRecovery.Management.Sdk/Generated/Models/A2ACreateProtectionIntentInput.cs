// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2A create protection intent input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2ACreateProtectionIntentInput : CreateProtectionIntentProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2ACreateProtectionIntentInput class.
        /// </summary>
        public A2ACreateProtectionIntentInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2ACreateProtectionIntentInput class.
        /// </summary>

        /// <param name="fabricObjectId">The fabric specific object Id of the virtual machine.
        /// </param>

        /// <param name="primaryLocation">The primary location for the virtual machine.
        /// </param>

        /// <param name="recoveryLocation">The recovery location for the virtual machine.
        /// </param>

        /// <param name="recoverySubscriptionId">The recovery subscription Id of the virtual machine.
        /// </param>

        /// <param name="recoveryAvailabilityType">The recovery availability type of the virtual machine.
        /// Possible values include: &#39;Single&#39;, &#39;AvailabilitySet&#39;, &#39;AvailabilityZone&#39;</param>

        /// <param name="protectionProfileCustomInput">The protection profile custom inputs.
        /// </param>

        /// <param name="recoveryResourceGroupId">The recovery resource group Id. Valid for V2 scenarios.
        /// </param>

        /// <param name="primaryStagingStorageAccountCustomInput">The primary staging storage account input.
        /// </param>

        /// <param name="recoveryAvailabilitySetCustomInput">The recovery availability set input.
        /// </param>

        /// <param name="recoveryVirtualNetworkCustomInput">The recovery virtual network input.
        /// </param>

        /// <param name="recoveryProximityPlacementGroupCustomInput">The recovery proximity placement group custom input.
        /// </param>

        /// <param name="autoProtectionOfDataDisk">A value indicating whether the auto protection is enabled.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>

        /// <param name="vmDisks">The list of vm disk inputs.
        /// </param>

        /// <param name="vmManagedDisks">The list of vm managed disk inputs.
        /// </param>

        /// <param name="multiVMGroupName">The multi vm group name.
        /// </param>

        /// <param name="multiVMGroupId">The multi vm group id.
        /// </param>

        /// <param name="recoveryBootDiagStorageAccount">The boot diagnostic storage account.
        /// </param>

        /// <param name="diskEncryptionInfo">The recovery disk encryption information (for two pass flows).
        /// </param>

        /// <param name="recoveryAvailabilityZone">The recovery availability zone.
        /// </param>

        /// <param name="agentAutoUpdateStatus">A value indicating whether the auto update is enabled.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>

        /// <param name="automationAccountAuthenticationType">A value indicating the authentication type for automation account. The
        /// default value is &#34;RunAsAccount&#34;.
        /// Possible values include: &#39;RunAsAccount&#39;, &#39;SystemAssignedIdentity&#39;</param>

        /// <param name="automationAccountArmId">The automation account arm id.
        /// </param>
        public A2ACreateProtectionIntentInput(string fabricObjectId, string primaryLocation, string recoveryLocation, string recoverySubscriptionId, string recoveryAvailabilityType, string recoveryResourceGroupId, ProtectionProfileCustomDetails protectionProfileCustomInput = default(ProtectionProfileCustomDetails), StorageAccountCustomDetails primaryStagingStorageAccountCustomInput = default(StorageAccountCustomDetails), RecoveryAvailabilitySetCustomDetails recoveryAvailabilitySetCustomInput = default(RecoveryAvailabilitySetCustomDetails), RecoveryVirtualNetworkCustomDetails recoveryVirtualNetworkCustomInput = default(RecoveryVirtualNetworkCustomDetails), RecoveryProximityPlacementGroupCustomDetails recoveryProximityPlacementGroupCustomInput = default(RecoveryProximityPlacementGroupCustomDetails), string autoProtectionOfDataDisk = default(string), System.Collections.Generic.IList<A2AProtectionIntentDiskInputDetails> vmDisks = default(System.Collections.Generic.IList<A2AProtectionIntentDiskInputDetails>), System.Collections.Generic.IList<A2AProtectionIntentManagedDiskInputDetails> vmManagedDisks = default(System.Collections.Generic.IList<A2AProtectionIntentManagedDiskInputDetails>), string multiVMGroupName = default(string), string multiVMGroupId = default(string), StorageAccountCustomDetails recoveryBootDiagStorageAccount = default(StorageAccountCustomDetails), DiskEncryptionInfo diskEncryptionInfo = default(DiskEncryptionInfo), string recoveryAvailabilityZone = default(string), string agentAutoUpdateStatus = default(string), string automationAccountAuthenticationType = default(string), string automationAccountArmId = default(string))

        {
            this.FabricObjectId = fabricObjectId;
            this.PrimaryLocation = primaryLocation;
            this.RecoveryLocation = recoveryLocation;
            this.RecoverySubscriptionId = recoverySubscriptionId;
            this.RecoveryAvailabilityType = recoveryAvailabilityType;
            this.ProtectionProfileCustomInput = protectionProfileCustomInput;
            this.RecoveryResourceGroupId = recoveryResourceGroupId;
            this.PrimaryStagingStorageAccountCustomInput = primaryStagingStorageAccountCustomInput;
            this.RecoveryAvailabilitySetCustomInput = recoveryAvailabilitySetCustomInput;
            this.RecoveryVirtualNetworkCustomInput = recoveryVirtualNetworkCustomInput;
            this.RecoveryProximityPlacementGroupCustomInput = recoveryProximityPlacementGroupCustomInput;
            this.AutoProtectionOfDataDisk = autoProtectionOfDataDisk;
            this.VMDisks = vmDisks;
            this.VMManagedDisks = vmManagedDisks;
            this.MultiVMGroupName = multiVMGroupName;
            this.MultiVMGroupId = multiVMGroupId;
            this.RecoveryBootDiagStorageAccount = recoveryBootDiagStorageAccount;
            this.DiskEncryptionInfo = diskEncryptionInfo;
            this.RecoveryAvailabilityZone = recoveryAvailabilityZone;
            this.AgentAutoUpdateStatus = agentAutoUpdateStatus;
            this.AutomationAccountAuthenticationType = automationAccountAuthenticationType;
            this.AutomationAccountArmId = automationAccountArmId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the fabric specific object Id of the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId {get; set; }

        /// <summary>
        /// Gets or sets the primary location for the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryLocation")]
        public string PrimaryLocation {get; set; }

        /// <summary>
        /// Gets or sets the recovery location for the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryLocation")]
        public string RecoveryLocation {get; set; }

        /// <summary>
        /// Gets or sets the recovery subscription Id of the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoverySubscriptionId")]
        public string RecoverySubscriptionId {get; set; }

        /// <summary>
        /// Gets or sets the recovery availability type of the virtual machine. Possible values include: &#39;Single&#39;, &#39;AvailabilitySet&#39;, &#39;AvailabilityZone&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAvailabilityType")]
        public string RecoveryAvailabilityType {get; set; }

        /// <summary>
        /// Gets or sets the protection profile custom inputs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectionProfileCustomInput")]
        public ProtectionProfileCustomDetails ProtectionProfileCustomInput {get; set; }

        /// <summary>
        /// Gets or sets the recovery resource group Id. Valid for V2 scenarios.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId {get; set; }

        /// <summary>
        /// Gets or sets the primary staging storage account input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryStagingStorageAccountCustomInput")]
        public StorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput {get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAvailabilitySetCustomInput")]
        public RecoveryAvailabilitySetCustomDetails RecoveryAvailabilitySetCustomInput {get; set; }

        /// <summary>
        /// Gets or sets the recovery virtual network input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryVirtualNetworkCustomInput")]
        public RecoveryVirtualNetworkCustomDetails RecoveryVirtualNetworkCustomInput {get; set; }

        /// <summary>
        /// Gets or sets the recovery proximity placement group custom input.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryProximityPlacementGroupCustomInput")]
        public RecoveryProximityPlacementGroupCustomDetails RecoveryProximityPlacementGroupCustomInput {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the auto protection is enabled. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoProtectionOfDataDisk")]
        public string AutoProtectionOfDataDisk {get; set; }

        /// <summary>
        /// Gets or sets the list of vm disk inputs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmDisks")]
        public System.Collections.Generic.IList<A2AProtectionIntentDiskInputDetails> VMDisks {get; set; }

        /// <summary>
        /// Gets or sets the list of vm managed disk inputs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmManagedDisks")]
        public System.Collections.Generic.IList<A2AProtectionIntentManagedDiskInputDetails> VMManagedDisks {get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVMGroupName {get; set; }

        /// <summary>
        /// Gets or sets the multi vm group id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVMGroupId {get; set; }

        /// <summary>
        /// Gets or sets the boot diagnostic storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryBootDiagStorageAccount")]
        public StorageAccountCustomDetails RecoveryBootDiagStorageAccount {get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption information (for two pass flows).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskEncryptionInfo")]
        public DiskEncryptionInfo DiskEncryptionInfo {get; set; }

        /// <summary>
        /// Gets or sets the recovery availability zone.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAvailabilityZone")]
        public string RecoveryAvailabilityZone {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the auto update is enabled. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "agentAutoUpdateStatus")]
        public string AgentAutoUpdateStatus {get; set; }

        /// <summary>
        /// Gets or sets a value indicating the authentication type for automation
        /// account. The default value is &#34;RunAsAccount&#34;. Possible values include: &#39;RunAsAccount&#39;, &#39;SystemAssignedIdentity&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "automationAccountAuthenticationType")]
        public string AutomationAccountAuthenticationType {get; set; }

        /// <summary>
        /// Gets or sets the automation account arm id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "automationAccountArmId")]
        public string AutomationAccountArmId {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.FabricObjectId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "FabricObjectId");
            }
            if (this.PrimaryLocation == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PrimaryLocation");
            }
            if (this.RecoveryLocation == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryLocation");
            }
            if (this.RecoverySubscriptionId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoverySubscriptionId");
            }
            if (this.RecoveryAvailabilityType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryAvailabilityType");
            }
            if (this.RecoveryResourceGroupId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryResourceGroupId");
            }












            if (this.VMDisks != null)
            {
                foreach (var element in this.VMDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.VMManagedDisks != null)
            {
                foreach (var element in this.VMManagedDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }








        }
    }
}