/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Adaptive.SimpleBinaryEncoding;

namespace Adaptive.SimpleBinaryEncoding.Ir.Generated
{
    public enum PresenceCodec : byte
    {
        REQUIRED = 0,
        OPTIONAL = 1,
        CONSTANT = 2,
        NULL_VALUE = 255
    }
}
