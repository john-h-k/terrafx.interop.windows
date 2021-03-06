// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct INTENT_TO_SEAL_ATTRIBUTE
    {
        [NativeTypeName("ULONG")]
        public uint version;

        [NativeTypeName("BOOLEAN")]
        public byte seal;
    }
}
