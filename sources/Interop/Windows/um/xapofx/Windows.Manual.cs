// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_FXEQ = new Guid(0xF5E01117, 0xD6C4, 0x485A, 0xA3, 0xF5, 0x69, 0x51, 0x96, 0xF3, 0xDB, 0xFA);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_FXMasteringLimiter = new Guid(0xC4137916, 0x2BE1, 0x46FD, 0x85, 0x99, 0x44, 0x15, 0x36, 0xF4, 0x98, 0x56);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_FXReverb = new Guid(0x7D9ACA56, 0xCB68, 0x4807, 0xB6, 0x32, 0xB1, 0x37, 0x35, 0x2E, 0x85, 0x96);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_FXEcho = new Guid(0x5039D740, 0xF736, 0x449A, 0x84, 0xD3, 0xA5, 0x62, 0x02, 0x55, 0x7B, 0x87);
    }
}
