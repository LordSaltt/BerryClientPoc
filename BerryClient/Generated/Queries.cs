using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            100,
            80,
            69,
            117,
            55,
            47,
            87,
            54,
            106,
            80,
            118,
            98,
            98,
            76,
            52,
            83,
            49,
            98,
            69,
            90,
            107,
            81,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            71,
            101,
            116,
            80,
            114,
            111,
            100,
            117,
            99,
            116,
            115,
            32,
            123,
            32,
            112,
            114,
            111,
            100,
            117,
            99,
            116,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            100,
            101,
            115,
            99,
            114,
            105,
            112,
            116,
            105,
            111,
            110,
            32,
            115,
            116,
            97,
            116,
            117,
            115,
            32,
            117,
            79,
            77,
            32,
            98,
            114,
            97,
            110,
            100,
            73,
            100,
            32,
            66,
            114,
            97,
            110,
            100,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            125,
            32,
            67,
            97,
            116,
            101,
            103,
            111,
            114,
            121,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query GetProducts {
              products {
                name
                description
                status
                uOM
                brandId
                Brand {
                  name
                }
                Category {
                  name
                }
              }
            }";
    }
}
