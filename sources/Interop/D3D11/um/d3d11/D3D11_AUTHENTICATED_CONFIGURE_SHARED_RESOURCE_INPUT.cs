// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT
    {
        public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

        public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;

        [NativeTypeName("HANDLE")]
        public void* ProcessHandle;

        [NativeTypeName("BOOL")]
        public int AllowAccess;
    }
}