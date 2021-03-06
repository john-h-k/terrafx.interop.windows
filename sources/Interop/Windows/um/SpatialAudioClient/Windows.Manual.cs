// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IAudioFormatEnumerator = new Guid(0xDCDAA858, 0x895A, 0x4A22, 0xA5, 0xEB, 0x67, 0xBD, 0xA5, 0x06, 0x09, 0x6D);

        public static readonly Guid IID_ISpatialAudioClient = new Guid(0xBBF8E066, 0xAAAA, 0x49BE, 0x9A, 0x4D, 0xFD, 0x2A, 0x85, 0x8E, 0xA2, 0x7F);

        public static readonly Guid IID_ISpatialAudioObject = new Guid(0xDDE28967, 0x521B, 0x46E5, 0x8F, 0x00, 0xBD, 0x6F, 0x2B, 0xC8, 0xAB, 0x1D);
        
        public static readonly Guid IID_ISpatialAudioObjectBase = new Guid(0xCCE0B8F2, 0x8D4D, 0x4EFB, 0xA8, 0xCF, 0x3D, 0x6E, 0xCF, 0x1C, 0x30, 0xE0);
        
        public static readonly Guid IID_ISpatialAudioObjectRenderStream = new Guid(0xBAB5F473, 0xB423, 0x477B, 0x85, 0xF5, 0xB5, 0xA3, 0x32, 0xA0, 0x41, 0x53);
        
        public static readonly Guid IID_ISpatialAudioObjectRenderStreamBase = new Guid(0xFEAAF403, 0xC1D8, 0x450D, 0xAA, 0x05, 0xE0, 0xCC, 0xEE, 0x75, 0x02, 0xA8);
        
        public static readonly Guid IID_ISpatialAudioObjectRenderStreamNotify = new Guid(0xDDDF83E6, 0x68D7, 0x4C70, 0x88, 0x3F, 0xA1, 0x83, 0x6A, 0xFB, 0x4A, 0x50);
    }
}
