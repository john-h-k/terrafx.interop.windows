// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NodeCount;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("STORAGE_PHYSICAL_NODE_DATA [1]")]
        public _Node_e__FixedBuffer Node;

        public partial struct _Node_e__FixedBuffer
        {
            public STORAGE_PHYSICAL_NODE_DATA e0;

            public ref STORAGE_PHYSICAL_NODE_DATA this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<STORAGE_PHYSICAL_NODE_DATA> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
