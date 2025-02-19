﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Shared;

namespace Azure.Storage.Blobs
{
    /// <summary>
    /// Provides the configurations to connecting to the Blob Service and to create the Blob Clients
    /// </summary>
    internal class BlobClientConfiguration : StorageClientConfiguration
    {
        /// <summary>
        /// The versions of Azure Blob Storage supported by this client
        /// library.  For more, see
        /// <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/versioning-for-the-azure-storage-services">
        /// Versioning for Azure Storage Services</see>.
        /// </summary>
        public virtual BlobClientOptions.ServiceVersion Version { get; internal set; }

        /// <summary>
        /// The encryption key to be used with client provided key server-side encryption.
        /// </summary>
        public virtual CustomerProvidedKey? CustomerProvidedKey { get; internal set; }

        public virtual TransferValidationOptions TransferValidation { get; internal set; }

        public string EncryptionScope { get; internal set; }

        public bool TrimBlobNameSlashes { get; internal set; }

        public BlobClientConfiguration(
            HttpPipeline pipeline,
            TokenCredential tokenCredential,
            ClientDiagnostics clientDiagnostics,
            BlobClientOptions.ServiceVersion version,
            CustomerProvidedKey? customerProvidedKey,
            TransferValidationOptions transferValidation,
            string encryptionScope,
            bool trimBlobNameSlashes)
            : base(pipeline, tokenCredential, clientDiagnostics)
        {
            Version = version;
            CustomerProvidedKey = customerProvidedKey;
            TransferValidation = transferValidation;
            EncryptionScope = encryptionScope;
            TrimBlobNameSlashes = trimBlobNameSlashes;
        }

        public BlobClientConfiguration(
            HttpPipeline pipeline,
            StorageSharedKeyCredential sharedKeyCredential,
            ClientDiagnostics clientDiagnostics,
            BlobClientOptions.ServiceVersion version,
            CustomerProvidedKey? customerProvidedKey,
            TransferValidationOptions transferValidation,
            string encryptionScope,
            bool trimBlobNameSlashes)
            : base(pipeline, sharedKeyCredential, clientDiagnostics)
        {
            Version = version;
            CustomerProvidedKey = customerProvidedKey;
            TransferValidation = transferValidation;
            EncryptionScope = encryptionScope;
            TrimBlobNameSlashes = trimBlobNameSlashes;
        }

        internal static BlobClientConfiguration DeepCopy(BlobClientConfiguration originalClientConfiguration)
            => new BlobClientConfiguration(
                pipeline: originalClientConfiguration.Pipeline,
                sharedKeyCredential: originalClientConfiguration.SharedKeyCredential,
                clientDiagnostics: originalClientConfiguration.ClientDiagnostics,
                version: originalClientConfiguration.Version,
                customerProvidedKey: originalClientConfiguration.CustomerProvidedKey,
                transferValidation: originalClientConfiguration.TransferValidation,
                encryptionScope: originalClientConfiguration.EncryptionScope,
                trimBlobNameSlashes: originalClientConfiguration.TrimBlobNameSlashes);
    }
}
