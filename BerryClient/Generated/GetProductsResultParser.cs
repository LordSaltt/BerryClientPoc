using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetProductsResultParser
        : JsonResultParserBase<IGetProducts>
    {
        private readonly IValueSerializer _stringSerializer;
        private readonly IValueSerializer _intSerializer;

        public GetProductsResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _stringSerializer = serializerResolver.Get("String");
            _intSerializer = serializerResolver.Get("Int");
        }

        protected override IGetProducts ParserData(JsonElement data)
        {
            return new GetProducts
            (
                ParseGetProductsProducts(data, "products")
            );

        }

        private global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IProduct> ParseGetProductsProducts(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            int objLength = obj.GetArrayLength();
            var list = new global::BerryClient.IProduct[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new Product
                (
                    DeserializeNullableString(element, "name"),
                    DeserializeNullableString(element, "description"),
                    DeserializeNullableString(element, "status"),
                    DeserializeNullableString(element, "uOM"),
                    DeserializeInt(element, "brandId"),
                    ParseGetProductsProductsBrand(element, "Brand"),
                    ParseGetProductsProductsCategory(element, "Category")
                );

            }

            return list;
        }

        private global::BerryClient.IBrand ParseGetProductsProductsBrand(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Brand
            (
                DeserializeNullableString(obj, "name")
            );
        }

        private global::BerryClient.ICategory ParseGetProductsProductsCategory(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Category
            (
                DeserializeNullableString(obj, "name")
            );
        }

        private string DeserializeNullableString(JsonElement obj, string fieldName)
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (string)_stringSerializer.Deserialize(value.GetString());
        }

        private int DeserializeInt(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (int)_intSerializer.Deserialize(value.GetInt32());
        }
    }
}
