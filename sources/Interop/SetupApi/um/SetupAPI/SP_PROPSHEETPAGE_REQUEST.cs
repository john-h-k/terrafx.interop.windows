// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_PROPSHEETPAGE_REQUEST
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint PageRequested;

        [NativeTypeName("HDEVINFO")]
        public void* DeviceInfoSet;

        [NativeTypeName("PSP_DEVINFO_DATA")]
        public SP_DEVINFO_DATA* DeviceInfoData;
    }
}
