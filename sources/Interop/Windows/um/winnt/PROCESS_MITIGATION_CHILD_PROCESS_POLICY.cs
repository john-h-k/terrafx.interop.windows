// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESS_MITIGATION_CHILD_PROCESS_POLICY
    {
        [NativeTypeName("_PROCESS_MITIGATION_CHILD_PROCESS_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11854:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint Flags => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Flags, 1));

        public uint NoChildProcessCreation
        {
            get
            {
                return Anonymous.Anonymous.NoChildProcessCreation;
            }

            set
            {
                Anonymous.Anonymous.NoChildProcessCreation = value;
            }
        }

        public uint AuditNoChildProcessCreation
        {
            get
            {
                return Anonymous.Anonymous.AuditNoChildProcessCreation;
            }

            set
            {
                Anonymous.Anonymous.AuditNoChildProcessCreation = value;
            }
        }

        public uint AllowSecureProcessCreation
        {
            get
            {
                return Anonymous.Anonymous.AllowSecureProcessCreation;
            }

            set
            {
                Anonymous.Anonymous.AllowSecureProcessCreation = value;
            }
        }

        public uint ReservedFlags
        {
            get
            {
                return Anonymous.Anonymous.ReservedFlags;
            }

            set
            {
                Anonymous.Anonymous.ReservedFlags = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("_PROCESS_MITIGATION_CHILD_PROCESS_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11856:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint NoChildProcessCreation
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

                [NativeTypeName("DWORD : 1")]
                public uint AuditNoChildProcessCreation
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

                [NativeTypeName("DWORD : 1")]
                public uint AllowSecureProcessCreation
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

                [NativeTypeName("DWORD : 29")]
                public uint ReservedFlags
                {
                    get
                    {
                        return (_bitfield >> 3) & 0x1FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                    }
                }
            }
        }
    }
}
