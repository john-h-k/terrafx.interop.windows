// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("_DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:3159:5)")]
        public _Anonymous_e__Union Anonymous;

        public uint advancedColorSupported
        {
            get
            {
                return Anonymous.Anonymous.advancedColorSupported;
            }

            set
            {
                Anonymous.Anonymous.advancedColorSupported = value;
            }
        }

        public uint advancedColorEnabled
        {
            get
            {
                return Anonymous.Anonymous.advancedColorEnabled;
            }

            set
            {
                Anonymous.Anonymous.advancedColorEnabled = value;
            }
        }

        public uint wideColorEnforced
        {
            get
            {
                return Anonymous.Anonymous.wideColorEnforced;
            }

            set
            {
                Anonymous.Anonymous.wideColorEnforced = value;
            }
        }

        public uint advancedColorForceDisabled
        {
            get
            {
                return Anonymous.Anonymous.advancedColorForceDisabled;
            }

            set
            {
                Anonymous.Anonymous.advancedColorForceDisabled = value;
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

        public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;

        [NativeTypeName("UINT32")]
        public uint bitsPerColorChannel;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:3161:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorSupported
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

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorEnabled
                {
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint wideColorEnforced
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorForceDisabled
                {
                    get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("UINT32 : 28")]
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 4) & 0xFFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFFFFu << 4)) | ((value & 0xFFFFFFFu) << 4);
                    }
                }
            }
        }
    }
}
