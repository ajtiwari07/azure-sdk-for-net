// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherInferenceEvidence
    {
        internal static TrialMatcherInferenceEvidence DeserializeTrialMatcherInferenceEvidence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eligibilityCriteriaEvidence = default;
            Optional<ClinicalNoteEvidence> patientDataEvidence = default;
            Optional<ClinicalCodedElement> patientInfoEvidence = default;
            Optional<float> importance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eligibilityCriteriaEvidence"u8))
                {
                    eligibilityCriteriaEvidence = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("patientDataEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patientDataEvidence = ClinicalNoteEvidence.DeserializeClinicalNoteEvidence(property.Value);
                    continue;
                }
                if (property.NameEquals("patientInfoEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patientInfoEvidence = ClinicalCodedElement.DeserializeClinicalCodedElement(property.Value);
                    continue;
                }
                if (property.NameEquals("importance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importance = property.Value.GetSingle();
                    continue;
                }
            }
            return new TrialMatcherInferenceEvidence(eligibilityCriteriaEvidence, patientDataEvidence, patientInfoEvidence, Optional.ToNullable(importance));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherInferenceEvidence FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherInferenceEvidence(document.RootElement);
        }
    }
}
