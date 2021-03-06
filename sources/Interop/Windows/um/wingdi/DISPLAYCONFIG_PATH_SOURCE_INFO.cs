// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
    {
        public LUID adapterId;

        [NativeTypeName("UINT32")]
        public uint id;

        [NativeTypeName("DISPLAYCONFIG_PATH_SOURCE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2950:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint modeInfoIdx => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.modeInfoIdx, 1));

        public uint cloneGroupId
        {
            get
            {
                return Anonymous.Anonymous.cloneGroupId;
            }

            set
            {
                Anonymous.Anonymous.cloneGroupId = value;
            }
        }

        public uint sourceModeInfoIdx
        {
            get
            {
                return Anonymous.Anonymous.sourceModeInfoIdx;
            }

            set
            {
                Anonymous.Anonymous.sourceModeInfoIdx = value;
            }
        }

        [NativeTypeName("UINT32")]
        public uint statusFlags;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint modeInfoIdx;

            [FieldOffset(0)]
            [NativeTypeName("DISPLAYCONFIG_PATH_SOURCE_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wingdi.h:2953:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 16")]
                public uint cloneGroupId
                {
                    get
                    {
                        return _bitfield & 0xFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                    }
                }

                [NativeTypeName("UINT32 : 16")]
                public uint sourceModeInfoIdx
                {
                    get
                    {
                        return (_bitfield >> 16) & 0xFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
                    }
                }
            }
        }
    }
}
