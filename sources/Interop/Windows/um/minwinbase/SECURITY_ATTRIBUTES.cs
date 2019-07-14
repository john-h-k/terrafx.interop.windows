// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\minwinbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct SECURITY_ATTRIBUTES
    {
        #region Fields
        [NativeTypeName("DWORD")]
        public uint nLength;

        [NativeTypeName("LPVOID")]
        public void* lpSecurityDescriptor;

        [NativeTypeName("BOOL")]
        public int bInheritHandle;
        #endregion
    }
}