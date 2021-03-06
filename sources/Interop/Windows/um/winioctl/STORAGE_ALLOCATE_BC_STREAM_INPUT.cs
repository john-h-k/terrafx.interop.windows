// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_ALLOCATE_BC_STREAM_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint RequestsPerPeriod;

        [NativeTypeName("DWORD")]
        public uint Period;

        [NativeTypeName("BOOLEAN")]
        public byte RetryFailures;

        [NativeTypeName("BOOLEAN")]
        public byte Discardable;

        [NativeTypeName("BOOLEAN [2]")]
        public fixed byte Reserved1[2];

        [NativeTypeName("DWORD")]
        public uint AccessType;

        [NativeTypeName("DWORD")]
        public uint AccessMode;
    }
}
