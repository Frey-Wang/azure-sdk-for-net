// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the LedgerDigestUploads data model. </summary>
    public partial class LedgerDigestUploadsData : Resource
    {
        /// <summary> Initializes a new instance of LedgerDigestUploadsData. </summary>
        public LedgerDigestUploadsData()
        {
        }

        /// <summary> Initializes a new instance of LedgerDigestUploadsData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="digestStorageEndpoint"> The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger. </param>
        /// <param name="state"> Specifies the state of ledger digest upload. </param>
        internal LedgerDigestUploadsData(ResourceIdentifier id, string name, ResourceType type, string digestStorageEndpoint, LedgerDigestUploadsState? state) : base(id, name, type)
        {
            DigestStorageEndpoint = digestStorageEndpoint;
            State = state;
        }

        /// <summary> The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger. </summary>
        public string DigestStorageEndpoint { get; set; }
        /// <summary> Specifies the state of ledger digest upload. </summary>
        public LedgerDigestUploadsState? State { get; }
    }
}
