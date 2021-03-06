// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_SCRIPT_PROPERTIES
    {
        [NativeTypeName("UINT32")]
        public uint isoScriptCode;

        [NativeTypeName("UINT32")]
        public uint isoScriptNumber;

        [NativeTypeName("UINT32")]
        public uint clusterLookahead;

        [NativeTypeName("UINT32")]
        public uint justificationCharacter;

        public uint _bitfield;

        [NativeTypeName("UINT32 : 1")]
        public uint restrictCaretToClusters
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
        public uint usesWordDividers
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
        public uint isDiscreteWriting
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
        public uint isBlockWriting
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

        [NativeTypeName("UINT32 : 1")]
        public uint isDistributedWithinCluster
        {
            get
            {
                return (_bitfield >> 4) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint isConnectedWriting
        {
            get
            {
                return (_bitfield >> 5) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint isCursiveWriting
        {
            get
            {
                return (_bitfield >> 6) & 0x1u;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
            }
        }

        [NativeTypeName("UINT32 : 25")]
        public uint reserved
        {
            get
            {
                return (_bitfield >> 7) & 0x1FFFFFFu;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
            }
        }
    }
}
