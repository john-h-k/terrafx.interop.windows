// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_OR_CRL_BUNDLE
    {
        [NativeTypeName("DWORD")]
        public uint cItem;

        [NativeTypeName("PCERT_OR_CRL_BLOB")]
        public CERT_OR_CRL_BLOB* rgItem;
    }
}
