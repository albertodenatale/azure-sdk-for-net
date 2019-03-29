// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingSubscriptionsByBillingProfileOperations.
    /// </summary>
    public static partial class BillingSubscriptionsByBillingProfileOperationsExtensions
    {
            /// <summary>
            /// Lists billing subscriptions by billingProfileName.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            public static BillingSubscriptionsListResult List(this IBillingSubscriptionsByBillingProfileOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists billing subscriptions by billingProfileName.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingSubscriptionsListResult> ListAsync(this IBillingSubscriptionsByBillingProfileOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}