using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IProduct
    {
        string Name { get; }

        string Description { get; }

        string Status { get; }

        string UOM { get; }

        int BrandId { get; }

        global::BerryClient.IBrand Brand { get; }

        global::BerryClient.ICategory Category { get; }
    }
}
