// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.Network.Version2017_10_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network resource topology information for the given resource group.
    /// </summary>
    public partial class TopologyResource
    {
        /// <summary>
        /// Initializes a new instance of the TopologyResource class.
        /// </summary>
        public TopologyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopologyResource class.
        /// </summary>
        /// <param name="name">Name of the resource.</param>
        /// <param name="id">ID of the resource.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="associations">Holds the associations the resource has
        /// with other resources in the resource group.</param>
        public TopologyResource(string name = default(string), string id = default(string), string location = default(string), IList<TopologyAssociation> associations = default(IList<TopologyAssociation>))
        {
            Name = name;
            Id = id;
            Location = location;
            Associations = associations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets holds the associations the resource has with other
        /// resources in the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "associations")]
        public IList<TopologyAssociation> Associations { get; set; }

    }
}
