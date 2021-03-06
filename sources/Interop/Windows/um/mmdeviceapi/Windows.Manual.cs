// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid CLSID_MMDeviceEnumerator = new Guid(0XBCDE0395, 0XE52F, 0X467C, 0X8E, 0X3D, 0XC4, 0X57, 0X92, 0X91, 0X69, 0X2E);

        public static readonly Guid IID_IActivateAudioInterfaceAsyncOperation = new Guid(0x72A22D78, 0xCDE4, 0x431D, 0xB8, 0xCC, 0x84, 0x3A, 0x71, 0x19, 0x9B, 0x6D);

        public static readonly Guid IID_IActivateAudioInterfaceCompletionHandler = new Guid(0x41D949AB, 0x9862, 0x444A, 0x80, 0xF6, 0xC2, 0x61, 0x33, 0x4D, 0xA5, 0xEB);

        public static readonly Guid IID_IMMDevice = new Guid(0xD666063F, 0x1587, 0x4E43, 0x81, 0xF1, 0xB9, 0x48, 0xE8, 0x07, 0x36, 0x3F);

        public static readonly Guid IID_IMMDeviceActivator = new Guid(0x3B0D0EA4, 0xD0A9, 0x4B0E, 0x93, 0x5B, 0x09, 0x51, 0x67, 0x46, 0xFA, 0xC0);

        public static readonly Guid IID_IMMDeviceCollection = new Guid(0x0BD7A1BE, 0x7A1A, 0x44DB, 0x83, 0x97, 0xCC, 0x53, 0x92, 0x38, 0x7B, 0x5E);

        public static readonly Guid IID_IMMDeviceEnumerator = new Guid(0xA95664D2, 0x9614, 0x4F35, 0xA7, 0x46, 0xDE, 0x8D, 0xB6, 0x36, 0x17, 0xE6);

        public static readonly Guid IID_IMMEndpoint = new Guid(0x1BE09788, 0x6894, 0x4089, 0x85, 0x86, 0x9A, 0x2A, 0x6C, 0x26, 0x5A, 0xC5);

        public static readonly Guid IID_IMMNotificationClient = new Guid(0x7991EEC9, 0x7E89, 0x4D85, 0x83, 0x90, 0x6C, 0x70, 0x3C, 0xEC, 0x60, 0xC0); 

        public static readonly Guid LIBID_MMDeviceAPILib = new Guid(0X2FDAAFA3, 0X7523, 0X4F66, 0X99, 0X57, 0X9D, 0X5E, 0X7F, 0XE6, 0X98, 0XF6);
    }
}
