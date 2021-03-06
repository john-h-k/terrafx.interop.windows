// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC1
    {
        public DXGI_FORMAT Format;

        public D3D11_UAV_DIMENSION ViewDimension;

        [NativeTypeName("D3D11_UNORDERED_ACCESS_VIEW_DESC1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11_3.h:1627:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref D3D11_BUFFER_UAV Buffer => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Buffer, 1));

        public ref D3D11_TEX1D_UAV Texture1D => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1D, 1));

        public ref D3D11_TEX1D_ARRAY_UAV Texture1DArray => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1DArray, 1));

        public ref D3D11_TEX2D_UAV1 Texture2D => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));

        public ref D3D11_TEX2D_ARRAY_UAV1 Texture2DArray => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DArray, 1));

        public ref D3D11_TEX3D_UAV Texture3D => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture3D, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_BUFFER_UAV Buffer;

            [FieldOffset(0)]
            public D3D11_TEX1D_UAV Texture1D;

            [FieldOffset(0)]
            public D3D11_TEX1D_ARRAY_UAV Texture1DArray;

            [FieldOffset(0)]
            public D3D11_TEX2D_UAV1 Texture2D;

            [FieldOffset(0)]
            public D3D11_TEX2D_ARRAY_UAV1 Texture2DArray;

            [FieldOffset(0)]
            public D3D11_TEX3D_UAV Texture3D;
        }
    }
}
