// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_PACKED_MIP_INFO
    {
        [NativeTypeName("UINT8")]
        public byte NumStandardMips;

        [NativeTypeName("UINT8")]
        public byte NumPackedMips;

        [NativeTypeName("UINT")]
        public uint NumTilesForPackedMips;

        [NativeTypeName("UINT")]
        public uint StartTileIndexInOverallResource;

        public D3D12_PACKED_MIP_INFO(byte numStandardMips, byte numPackedMips, uint numTilesForPackedMips, uint startTileIndexInOverallResource)
        {
            NumStandardMips = numStandardMips;
            NumPackedMips = numPackedMips;
            NumTilesForPackedMips = numTilesForPackedMips;
            StartTileIndexInOverallResource = startTileIndexInOverallResource;
        }
    }
}