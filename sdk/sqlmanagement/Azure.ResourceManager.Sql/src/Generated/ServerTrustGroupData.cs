// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ServerTrustGroup data model. </summary>
    public partial class ServerTrustGroupData : Resource
    {
        /// <summary> Initializes a new instance of ServerTrustGroupData. </summary>
        public ServerTrustGroupData()
        {
            GroupMembers = new ChangeTrackingList<ServerInfo>();
            TrustScopes = new ChangeTrackingList<ServerTrustGroupPropertiesTrustScopesItem>();
        }

        /// <summary> Initializes a new instance of ServerTrustGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="groupMembers"> Group members information for the server trust group. </param>
        /// <param name="trustScopes"> Trust scope of the server trust group. </param>
        internal ServerTrustGroupData(ResourceIdentifier id, string name, ResourceType type, IList<ServerInfo> groupMembers, IList<ServerTrustGroupPropertiesTrustScopesItem> trustScopes) : base(id, name, type)
        {
            GroupMembers = groupMembers;
            TrustScopes = trustScopes;
        }

        /// <summary> Group members information for the server trust group. </summary>
        public IList<ServerInfo> GroupMembers { get; }
        /// <summary> Trust scope of the server trust group. </summary>
        public IList<ServerTrustGroupPropertiesTrustScopesItem> TrustScopes { get; }
    }
}
