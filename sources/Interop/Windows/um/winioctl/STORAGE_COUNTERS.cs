// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_COUNTERS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NumberOfCounters;

        [NativeTypeName("STORAGE_COUNTER [1]")]
        public _Counters_e__FixedBuffer Counters;

        public partial struct _Counters_e__FixedBuffer
        {
            public STORAGE_COUNTER e0;

            public ref STORAGE_COUNTER this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<STORAGE_COUNTER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
