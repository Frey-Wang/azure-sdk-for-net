// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates a server DNS alias. </summary>
    public partial class ServerDnsAliasCreateOrUpdateOperation : Operation<ServerDnsAlias>, IOperationSource<ServerDnsAlias>
    {
        private readonly OperationInternals<ServerDnsAlias> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ServerDnsAliasCreateOrUpdateOperation for mocking. </summary>
        protected ServerDnsAliasCreateOrUpdateOperation()
        {
        }

        internal ServerDnsAliasCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServerDnsAlias>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServerDnsAliasCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerDnsAlias Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerDnsAlias>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerDnsAlias>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerDnsAlias IOperationSource<ServerDnsAlias>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ServerDnsAlias(_operationBase, ServerDnsAliasData.DeserializeServerDnsAliasData(document.RootElement));
        }

        async ValueTask<ServerDnsAlias> IOperationSource<ServerDnsAlias>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ServerDnsAlias(_operationBase, ServerDnsAliasData.DeserializeServerDnsAliasData(document.RootElement));
        }
    }
}
