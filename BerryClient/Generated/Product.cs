using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Product
        : IProduct
    {
        public Product(
            string name, 
            string description, 
            string status, 
            string uOM, 
            int brandId, 
            global::BerryClient.IBrand brand)
        {
            Name = name;
            Description = description;
            Status = status;
            UOM = uOM;
            BrandId = brandId;
            Brand = brand;
        }

        public string Name { get; }

        public string Description { get; }

        public string Status { get; }

        public string UOM { get; }

        public int BrandId { get; }

        public global::BerryClient.IBrand Brand { get; }
    }
}
