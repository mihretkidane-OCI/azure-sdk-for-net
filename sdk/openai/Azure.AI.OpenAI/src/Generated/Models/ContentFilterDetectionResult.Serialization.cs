// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    /// <summary></summary>
    public partial class ContentFilterDetectionResult : IJsonModel<ContentFilterDetectionResult>
    {
        internal ContentFilterDetectionResult()
        {
        }

        void IJsonModel<ContentFilterDetectionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterDetectionResult)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("filtered") != true)
            {
                writer.WritePropertyName("filtered"u8);
                writer.WriteBooleanValue(Filtered);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("detected") != true)
            {
                writer.WritePropertyName("detected"u8);
                writer.WriteBooleanValue(Detected);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ContentFilterDetectionResult IJsonModel<ContentFilterDetectionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ContentFilterDetectionResult JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterDetectionResult)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentFilterDetectionResult(document.RootElement, options);
        }

        internal static ContentFilterDetectionResult DeserializeContentFilterDetectionResult(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool filtered = default;
            bool detected = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("filtered"u8))
                {
                    filtered = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("detected"u8))
                {
                    detected = prop.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ContentFilterDetectionResult(filtered, detected, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ContentFilterDetectionResult>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentFilterDetectionResult)} does not support writing '{options.Format}' format.");
            }
        }

        ContentFilterDetectionResult IPersistableModel<ContentFilterDetectionResult>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ContentFilterDetectionResult PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeContentFilterDetectionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentFilterDetectionResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentFilterDetectionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="contentFilterDetectionResult"> The <see cref="ContentFilterDetectionResult"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(ContentFilterDetectionResult contentFilterDetectionResult)
        {
            if (contentFilterDetectionResult == null)
            {
                return null;
            }
            return BinaryContent.Create(contentFilterDetectionResult, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="ContentFilterDetectionResult"/> from. </param>
        public static explicit operator ContentFilterDetectionResult(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeContentFilterDetectionResult(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
