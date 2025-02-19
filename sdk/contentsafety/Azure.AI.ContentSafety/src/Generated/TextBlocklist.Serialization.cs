// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    public partial class TextBlocklist
    {
        internal static TextBlocklist DeserializeTextBlocklist(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string blocklistName = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blocklistName"u8))
                {
                    blocklistName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new TextBlocklist(blocklistName, description);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextBlocklist FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTextBlocklist(document.RootElement);
        }
    }
}
