// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// UsersOperations operations.
    /// </summary>
    public partial interface IUsersOperations
    {
        /// <summary>
        /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <remarks>
        /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
        /// </remarks>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='filter'>
        /// Specify $filter=&#39;UserType eq &lt;type&gt;&#39; to filter on user type property
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<User>>> ListByDataBoxEdgeDeviceWithHttpMessagesAsync(string deviceName, string resourceGroupName, string filter = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the properties of the specified user.
        /// </summary>
        /// <remarks>
        /// Gets the properties of the specified user.
        /// </remarks>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The user name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<User>> GetWithHttpMessagesAsync(string deviceName, string name, string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a new user or updates an existing user&#39;s information on a Data Box
        /// Edge/Data Box Gateway device.
        /// </summary>
        /// <remarks>
        /// Creates a new user or updates an existing user&#39;s information on a Data Box
        /// Edge/Data Box Gateway device.
        /// </remarks>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The user name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='user'>
        /// The user details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<User>> CreateOrUpdateWithHttpMessagesAsync(string deviceName, string name, string resourceGroupName, User user, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes the user on a databox edge/gateway device.
        /// </summary>
        /// <remarks>
        /// Deletes the user on a databox edge/gateway device.
        /// </remarks>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The user name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string deviceName, string name, string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a new user or updates an existing user&#39;s information on a Data Box
        /// Edge/Data Box Gateway device.
        /// </summary>
        /// <remarks>
        /// Creates a new user or updates an existing user&#39;s information on a Data Box
        /// Edge/Data Box Gateway device.
        /// </remarks>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The user name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='user'>
        /// The user details.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<User>> BeginCreateOrUpdateWithHttpMessagesAsync(string deviceName, string name, string resourceGroupName, User user, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes the user on a databox edge/gateway device.
        /// </summary>
        /// <remarks>
        /// Deletes the user on a databox edge/gateway device.
        /// </remarks>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='name'>
        /// The user name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string deviceName, string name, string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <remarks>
        /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<User>>> ListByDataBoxEdgeDeviceNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}