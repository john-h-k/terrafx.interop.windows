// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILE_STANDARD_INFO
    {
        public LARGE_INTEGER AllocationSize;

        public LARGE_INTEGER EndOfFile;

        [NativeTypeName("DWORD")]
        public uint NumberOfLinks;

        [NativeTypeName("BOOLEAN")]
        public byte DeletePending;

        [NativeTypeName("BOOLEAN")]
        public byte Directory;
    }
}