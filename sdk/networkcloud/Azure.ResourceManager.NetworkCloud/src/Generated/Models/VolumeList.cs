// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VolumeList represents a list of volumes. </summary>
    internal partial class VolumeList
    {
        /// <summary> Initializes a new instance of VolumeList. </summary>
        internal VolumeList()
        {
            Value = new ChangeTrackingList<VolumeData>();
        }

        /// <summary> Initializes a new instance of VolumeList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of volumes. </param>
        internal VolumeList(string nextLink, IReadOnlyList<VolumeData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of volumes. </summary>
        public IReadOnlyList<VolumeData> Value { get; }
    }
}
