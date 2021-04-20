using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Brand
        : IBrand
    {
        public Brand(
            string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
