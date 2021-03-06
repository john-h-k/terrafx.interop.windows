// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IMAGE_NT_HEADERS
    {
        [NativeTypeName("DWORD")]
        public uint Signature;

        public IMAGE_FILE_HEADER FileHeader;

        [NativeTypeName("IMAGE_OPTIONAL_HEADER32")]
        public IMAGE_OPTIONAL_HEADER OptionalHeader;
    }
}
