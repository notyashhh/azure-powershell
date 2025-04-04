// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RolesOperations
    /// </summary>
    public static partial class RolesOperationsExtensions
    {
        /// <summary>
        /// Lists all the roles configured in a Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Role> ListByDataBoxEdgeDevice(this IRolesOperations operations, string deviceName, string resourceGroupName)
        {
                return ((IRolesOperations)operations).ListByDataBoxEdgeDeviceAsync(deviceName, resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all the roles configured in a Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Role>> ListByDataBoxEdgeDeviceAsync(this IRolesOperations operations, string deviceName, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByDataBoxEdgeDeviceWithHttpMessagesAsync(deviceName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets a specific role by name.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        public static Role Get(this IRolesOperations operations, string deviceName, string name, string resourceGroupName)
        {
                return ((IRolesOperations)operations).GetAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a specific role by name.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Role> GetAsync(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create or update a role.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        public static Role CreateOrUpdate(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, Role role)
        {
                return ((IRolesOperations)operations).CreateOrUpdateAsync(deviceName, name, resourceGroupName, role).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or update a role.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Role> CreateOrUpdateAsync(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, Role role, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(deviceName, name, resourceGroupName, role, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes the role on the device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        public static void Delete(this IRolesOperations operations, string deviceName, string name, string resourceGroupName)
        {
                ((IRolesOperations)operations).DeleteAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the role on the device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Create or update a role.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        public static Role BeginCreateOrUpdate(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, Role role)
        {
                return ((IRolesOperations)operations).BeginCreateOrUpdateAsync(deviceName, name, resourceGroupName, role).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or update a role.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Role> BeginCreateOrUpdateAsync(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, Role role, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(deviceName, name, resourceGroupName, role, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes the role on the device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        public static void BeginDelete(this IRolesOperations operations, string deviceName, string name, string resourceGroupName)
        {
                ((IRolesOperations)operations).BeginDeleteAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the role on the device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The role name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IRolesOperations operations, string deviceName, string name, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists all the roles configured in a Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Role> ListByDataBoxEdgeDeviceNext(this IRolesOperations operations, string nextPageLink)
        {
                return ((IRolesOperations)operations).ListByDataBoxEdgeDeviceNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all the roles configured in a Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Role>> ListByDataBoxEdgeDeviceNextAsync(this IRolesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByDataBoxEdgeDeviceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
