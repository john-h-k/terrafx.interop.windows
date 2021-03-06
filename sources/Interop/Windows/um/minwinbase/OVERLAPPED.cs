// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct OVERLAPPED
    {
        [NativeTypeName("ULONG_PTR")]
        public nuint Internal;

        [NativeTypeName("ULONG_PTR")]
        public nuint InternalHigh;

        [NativeTypeName("_OVERLAPPED::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:55:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Offset => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Offset, 1));

        public ref uint OffsetHigh => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.OffsetHigh, 1));

        public ref void* Pointer
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->Pointer;
                }
            }
        }

        [NativeTypeName("HANDLE")]
        public IntPtr hEvent;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_OVERLAPPED::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/minwinbase.h:56:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("PVOID")]
            public void* Pointer;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Offset;

                [NativeTypeName("DWORD")]
                public uint OffsetHigh;
            }
        }
    }
}
