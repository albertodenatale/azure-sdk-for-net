// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class UsageOperationsExtensions
    {
            /// <summary>
            /// Lists compute usages for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location upon which resource usage is queried.
            /// </param>
            public static ListUsagesResult List(this IUsageOperations operations, string location)
            {
                return Task.Factory.StartNew(s => ((IUsageOperations)s).ListAsync(location), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists compute usages for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location upon which resource usage is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ListUsagesResult> ListAsync( this IUsageOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ListUsagesResult> result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
