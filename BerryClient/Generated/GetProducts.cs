using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetProducts
        : IGetProducts
    {
        public GetProducts(
            global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IProduct> products)
        {
            Products = products;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IProduct> Products { get; }
    }
}
