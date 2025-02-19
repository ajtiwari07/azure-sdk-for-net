// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> CommunityAdvertisement represents the prefix and the communities that should be associated with that prefix. </summary>
    public partial class CommunityAdvertisement
    {
        /// <summary> Initializes a new instance of CommunityAdvertisement. </summary>
        /// <param name="communities"> The list of community strings to announce with this prefix. </param>
        /// <param name="subnetPrefix"> The subnet in CIDR format for which properties should be advertised. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communities"/> or <paramref name="subnetPrefix"/> is null. </exception>
        public CommunityAdvertisement(IEnumerable<string> communities, string subnetPrefix)
        {
            Argument.AssertNotNull(communities, nameof(communities));
            Argument.AssertNotNull(subnetPrefix, nameof(subnetPrefix));

            Communities = communities.ToList();
            SubnetPrefix = subnetPrefix;
        }

        /// <summary> Initializes a new instance of CommunityAdvertisement. </summary>
        /// <param name="communities"> The list of community strings to announce with this prefix. </param>
        /// <param name="subnetPrefix"> The subnet in CIDR format for which properties should be advertised. </param>
        internal CommunityAdvertisement(IList<string> communities, string subnetPrefix)
        {
            Communities = communities;
            SubnetPrefix = subnetPrefix;
        }

        /// <summary> The list of community strings to announce with this prefix. </summary>
        public IList<string> Communities { get; }
        /// <summary> The subnet in CIDR format for which properties should be advertised. </summary>
        public string SubnetPrefix { get; set; }
    }
}
