// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct IMAGE_TLS_DIRECTORY64
    {
        [NativeTypeName("ULONGLONG")]
        public ulong StartAddressOfRawData;

        [NativeTypeName("ULONGLONG")]
        public ulong EndAddressOfRawData;

        [NativeTypeName("ULONGLONG")]
        public ulong AddressOfIndex;

        [NativeTypeName("ULONGLONG")]
        public ulong AddressOfCallBacks;

        [NativeTypeName("DWORD")]
        public uint SizeOfZeroFill;

        [NativeTypeName("_IMAGE_TLS_DIRECTORY64::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18196:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Characteristics => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Characteristics, 1));

        public uint Reserved0
        {
            get
            {
                return Anonymous.Anonymous.Reserved0;
            }

            set
            {
                Anonymous.Anonymous.Reserved0 = value;
            }
        }

        public uint Alignment
        {
            get
            {
                return Anonymous.Anonymous.Alignment;
            }

            set
            {
                Anonymous.Anonymous.Alignment = value;
            }
        }

        public uint Reserved1
        {
            get
            {
                return Anonymous.Anonymous.Reserved1;
            }

            set
            {
                Anonymous.Anonymous.Reserved1 = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Characteristics;

            [FieldOffset(0)]
            [NativeTypeName("_IMAGE_TLS_DIRECTORY64::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18198:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 20")]
                public uint Reserved0
                {
                    get
                    {
                        return _bitfield & 0xFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu);
                    }
                }

                [NativeTypeName("DWORD : 4")]
                public uint Alignment
                {
                    get
                    {
                        return (_bitfield >> 20) & 0xFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFu << 20)) | ((value & 0xFu) << 20);
                    }
                }

                [NativeTypeName("DWORD : 8")]
                public uint Reserved1
                {
                    get
                    {
                        return (_bitfield >> 24) & 0xFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                    }
                }
            }
        }
    }
}
