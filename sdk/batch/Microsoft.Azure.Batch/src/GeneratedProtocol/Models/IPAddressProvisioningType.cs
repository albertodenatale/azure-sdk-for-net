// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IPAddressProvisioningType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IPAddressProvisioningType
    {
        /// <summary>
        /// A public IP will be created and managed by Batch. There may be
        /// multiple public IPs depending on the size of the Pool.
        /// </summary>
        [EnumMember(Value = "batchmanaged")]
        BatchManaged,
        /// <summary>
        /// Public IPs are provided by the user and will be used to provision
        /// the Compute Nodes.
        /// </summary>
        [EnumMember(Value = "usermanaged")]
        UserManaged,
        /// <summary>
        /// No public IP Address will be created.
        /// </summary>
        [EnumMember(Value = "nopublicipaddresses")]
        NoPublicIPAddresses
    }
    internal static class IPAddressProvisioningTypeEnumExtension
    {
        internal static string ToSerializedValue(this IPAddressProvisioningType? value)
        {
            return value == null ? null : ((IPAddressProvisioningType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IPAddressProvisioningType value)
        {
            switch( value )
            {
                case IPAddressProvisioningType.BatchManaged:
                    return "batchmanaged";
                case IPAddressProvisioningType.UserManaged:
                    return "usermanaged";
                case IPAddressProvisioningType.NoPublicIPAddresses:
                    return "nopublicipaddresses";
            }
            return null;
        }

        internal static IPAddressProvisioningType? ParseIPAddressProvisioningType(this string value)
        {
            switch( value )
            {
                case "batchmanaged":
                    return IPAddressProvisioningType.BatchManaged;
                case "usermanaged":
                    return IPAddressProvisioningType.UserManaged;
                case "nopublicipaddresses":
                    return IPAddressProvisioningType.NoPublicIPAddresses;
            }
            return null;
        }
    }
}
