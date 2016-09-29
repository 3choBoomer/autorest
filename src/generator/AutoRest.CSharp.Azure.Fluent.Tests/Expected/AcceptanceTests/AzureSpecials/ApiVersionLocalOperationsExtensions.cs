// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ApiVersionLocalOperations.
    /// </summary>
    public static partial class ApiVersionLocalOperationsExtensions
    {
            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetMethodLocalValid(this IApiVersionLocalOperations operations)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetMethodLocalValidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetMethodLocalValidAsync(this IApiVersionLocalOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetMethodLocalValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// null to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value null, this should
            /// result in no serialized parameter
            /// </param>
            public static void GetMethodLocalNull(this IApiVersionLocalOperations operations, string apiVersion = default(string))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetMethodLocalNullAsync(apiVersion), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// null to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value null, this should
            /// result in no serialized parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetMethodLocalNullAsync(this IApiVersionLocalOperations operations, string apiVersion = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetMethodLocalNullWithHttpMessagesAsync(apiVersion, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetPathLocalValid(this IApiVersionLocalOperations operations)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetPathLocalValidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetPathLocalValidAsync(this IApiVersionLocalOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetPathLocalValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetSwaggerLocalValid(this IApiVersionLocalOperations operations)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetSwaggerLocalValidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetSwaggerLocalValidAsync(this IApiVersionLocalOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetSwaggerLocalValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

    }
}