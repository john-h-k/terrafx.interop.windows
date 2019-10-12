// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_SUBRESOURCE_DATA
    {
        [NativeTypeName("const void *")]
        public void* pSysMem;

        [NativeTypeName("UINT")]
        public uint SysMemPitch;

        [NativeTypeName("UINT")]
        public uint SysMemSlicePitch;
    }
}