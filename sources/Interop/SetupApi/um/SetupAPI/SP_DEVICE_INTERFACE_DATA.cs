// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct SP_DEVICE_INTERFACE_DATA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("GUID")]
        public Guid InterfaceClassGuid;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr Reserved;
    }
}
