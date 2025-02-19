// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> General information regarding the current resource. </summary>
    internal partial class ServiceResourceDetails
    {
        /// <summary> Initializes a new instance of ServiceResourceDetails. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDocumentModels"/> is null. </exception>
        internal ServiceResourceDetails(CustomDocumentModelsDetails customDocumentModels)
        {
            Argument.AssertNotNull(customDocumentModels, nameof(customDocumentModels));

            CustomDocumentModels = customDocumentModels;
        }

        /// <summary> Initializes a new instance of ServiceResourceDetails. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <param name="customNeuralDocumentModelBuilds"> Quota used, limit, and next reset date/time. </param>
        internal ServiceResourceDetails(CustomDocumentModelsDetails customDocumentModels, QuotaDetails customNeuralDocumentModelBuilds)
        {
            CustomDocumentModels = customDocumentModels;
            CustomNeuralDocumentModelBuilds = customNeuralDocumentModelBuilds;
        }

        /// <summary> Details regarding custom document models. </summary>
        public CustomDocumentModelsDetails CustomDocumentModels { get; }
        /// <summary> Quota used, limit, and next reset date/time. </summary>
        public QuotaDetails CustomNeuralDocumentModelBuilds { get; }
    }
}
