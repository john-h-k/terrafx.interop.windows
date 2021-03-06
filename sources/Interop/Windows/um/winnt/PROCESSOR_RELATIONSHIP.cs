// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROCESSOR_RELATIONSHIP
    {
        [NativeTypeName("BYTE")]
        public byte Flags;

        [NativeTypeName("BYTE")]
        public byte EfficiencyClass;

        [NativeTypeName("BYTE [20]")]
        public fixed byte Reserved[20];

        [NativeTypeName("WORD")]
        public ushort GroupCount;

        [NativeTypeName("GROUP_AFFINITY [1]")]
        public _GroupMask_e__FixedBuffer GroupMask;

        public partial struct _GroupMask_e__FixedBuffer
        {
            public GROUP_AFFINITY e0;

            public ref GROUP_AFFINITY this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<GROUP_AFFINITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
