// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_SET_TARGET_PERSISTENCE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("DISPLAYCONFIG_SET_TARGET_PERSISTENCE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:3121:5)")]
        public _Anonymous_e__Union Anonymous;

        public uint bootPersistenceOn
        {
            get
            {
                return Anonymous.Anonymous.bootPersistenceOn;
            }

            set
            {
                Anonymous.Anonymous.bootPersistenceOn = value;
            }
        }

        public uint reserved
        {
            get
            {
                return Anonymous.Anonymous.reserved;
            }

            set
            {
                Anonymous.Anonymous.reserved = value;
            }
        }

        public ref uint value => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.value, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DISPLAYCONFIG_SET_TARGET_PERSISTENCE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:3123:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint bootPersistenceOn
                {
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }
    }
}
