// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the DeletedServer data model. </summary>
    public partial class DeletedServerData : Resource
    {
        /// <summary> Initializes a new instance of DeletedServerData. </summary>
        public DeletedServerData()
        {
        }

        /// <summary> Initializes a new instance of DeletedServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="version"> The version of the deleted server. </param>
        /// <param name="deletionTime"> The deletion time of the deleted server. </param>
        /// <param name="originalId"> The original ID of the server before deletion. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of the server. </param>
        internal DeletedServerData(ResourceIdentifier id, string name, ResourceType type, string version, DateTimeOffset? deletionTime, string originalId, string fullyQualifiedDomainName) : base(id, name, type)
        {
            Version = version;
            DeletionTime = deletionTime;
            OriginalId = originalId;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
        }

        /// <summary> The version of the deleted server. </summary>
        public string Version { get; }
        /// <summary> The deletion time of the deleted server. </summary>
        public DateTimeOffset? DeletionTime { get; }
        /// <summary> The original ID of the server before deletion. </summary>
        public string OriginalId { get; }
        /// <summary> The fully qualified domain name of the server. </summary>
        public string FullyQualifiedDomainName { get; }
    }
}
