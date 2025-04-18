// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.MixedReality.Common;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    public partial class AssetUploadUriResult
    {
        internal static AssetUploadUriResult DeserializeAssetUploadUriResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string inputAssetUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputAssetUri"u8))
                {
                    inputAssetUri = property.Value.GetString();
                    continue;
                }
            }
            return new AssetUploadUriResult(inputAssetUri);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssetUploadUriResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAssetUploadUriResult(document.RootElement);
        }
    }
}
