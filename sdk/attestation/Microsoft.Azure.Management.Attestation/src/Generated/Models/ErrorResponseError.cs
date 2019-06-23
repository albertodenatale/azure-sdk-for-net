// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response
    /// </summary>
    public partial class ErrorResponseError
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseError class.
        /// </summary>
        public ErrorResponseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseError class.
        /// </summary>
        /// <param name="code">Description of the error.</param>
        /// <param name="message">Service specific error code.</param>
        public ErrorResponseError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the error.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets service specific error code.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}