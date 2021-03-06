// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct HEAACWAVEINFO
    {
        public WAVEFORMATEX wfx;

        [NativeTypeName("WORD")]
        public ushort wPayloadType;

        [NativeTypeName("WORD")]
        public ushort wAudioProfileLevelIndication;

        [NativeTypeName("WORD")]
        public ushort wStructType;

        [NativeTypeName("WORD")]
        public ushort wReserved1;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }
}
