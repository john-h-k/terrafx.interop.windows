// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int MF_SOURCE_READER_INVALID_STREAM_INDEX = unchecked((int)0xFFFFFFFF);

        public const int MF_SOURCE_READER_ALL_STREAMS = unchecked((int)0xFFFFFFFE);

        public const int MF_SOURCE_READER_ANY_STREAM = unchecked((int)0xFFFFFFFE);

        public const int MF_SOURCE_READER_FIRST_AUDIO_STREAM = unchecked((int)0xFFFFFFFD);

        public const int MF_SOURCE_READER_FIRST_VIDEO_STREAM = unchecked((int)0xFFFFFFFC);

        public const int MF_SOURCE_READER_MEDIASOURCE = unchecked((int)0xFFFFFFFF);

        public const int MF_SOURCE_READER_CURRENT_TYPE_INDEX = unchecked((int)0xFFFFFFFF);

        public const int MF_SINK_WRITER_INVALID_STREAM_INDEX = unchecked((int)0xFFFFFFFF);

        public const int MF_SINK_WRITER_ALL_STREAMS = unchecked((int)0xFFFFFFFE);

        public const int MF_SINK_WRITER_MEDIASINK = unchecked((int)0xFFFFFFFF);

        public static readonly Guid CLSID_MFReadWriteClassFactory = new Guid(0x48E2ED0F, 0x98C2, 0x4A37, 0xBE, 0xD5, 0x16, 0x63, 0x12, 0xDD, 0xD8, 0x3F);

        public static readonly Guid IID_IMFReadWriteClassFactory = new Guid(0xE7FE2E12, 0x661C, 0x40DA, 0x92, 0xF9, 0x4F, 0x00, 0x2A, 0xB6, 0x76, 0x27);

        public static readonly Guid CLSID_MFSourceReader = new Guid(0x1777133C, 0x0881, 0x411B, 0xA5, 0x77, 0xAD, 0x54, 0x5F, 0x07, 0x14, 0xC4);

        public static readonly Guid MF_SOURCE_READER_ASYNC_CALLBACK = new Guid(0x1E3DBEAC, 0xBB43, 0x4C35, 0xB5, 0x07, 0xCD, 0x64, 0x44, 0x64, 0xC9, 0x65);

        public static readonly Guid MF_SOURCE_READER_D3D_MANAGER = new Guid(0xEC822DA2, 0xE1E9, 0x4B29, 0xA0, 0xD8, 0x56, 0x3C, 0x71, 0x9F, 0x52, 0x69);

        public static readonly Guid MF_SOURCE_READER_DISABLE_DXVA = new Guid(0xAA456CFD, 0x3943, 0x4A1E, 0xA7, 0x7D, 0x18, 0x38, 0xC0, 0xEA, 0x2E, 0x35);

        public static readonly Guid MF_SOURCE_READER_MEDIASOURCE_CONFIG = new Guid(0x9085ABEB, 0x0354, 0x48F9, 0xAB, 0xB5, 0x20, 0x0D, 0xF8, 0x38, 0xC6, 0x8E);

        public static readonly Guid MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS = new Guid(0x6D23F5C8, 0xC5D7, 0x4A9B, 0x99, 0x71, 0x5D, 0x11, 0xF8, 0xBC, 0xA8, 0x80);

        public static readonly Guid MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING = new Guid(0xFB394F3D, 0xCCF1, 0x42EE, 0xBB, 0xB3, 0xF9, 0xB8, 0x45, 0xD5, 0x68, 0x1D);

        public static readonly Guid MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING = new Guid(0x0F81DA2C, 0xB537, 0x4672, 0xA8, 0xB2, 0xA6, 0x81, 0xB1, 0x73, 0x07, 0xA3);

        public static readonly Guid MF_SOURCE_READER_DISABLE_CAMERA_PLUGINS = new Guid(0x9D3365DD, 0x058F, 0x4CFB, 0x9F, 0x97, 0xB3, 0x14, 0xCC, 0x99, 0xC8, 0xAD);

        public static readonly Guid MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN = new Guid(0x56B67165, 0x219E, 0x456D, 0xA2, 0x2E, 0x2D, 0x30, 0x04, 0xC7, 0xFE, 0x56);

        public static readonly Guid MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMS = new Guid(0xDFD4F008, 0xB5FD, 0x4E78, 0xAE, 0x44, 0x62, 0xA1, 0xE6, 0x7B, 0xBE, 0x27);

        public static readonly Guid MF_SOURCE_READER_D3D11_BIND_FLAGS = new Guid(0x33F3197B, 0xF73A, 0x4E14, 0x8D, 0x85, 0x0E, 0x4C, 0x43, 0x68, 0x78, 0x8D);

        public static readonly Guid IID_IMFSourceReader = new Guid(0x70AE66F2, 0xC809, 0x4E4F, 0x89, 0x15, 0xBD, 0xCB, 0x40, 0x6B, 0x79, 0x93);

        public static readonly Guid IID_IMFSourceReaderEx = new Guid(0x7B981CF0, 0x560E, 0x4116, 0x98, 0x75, 0xB0, 0x99, 0x89, 0x5F, 0x23, 0xD7);

        public static readonly Guid IID_IMFSourceReaderCallback = new Guid(0xDEEC8D99, 0xFA1D, 0x4D82, 0x84, 0xC2, 0x2C, 0x89, 0x69, 0x94, 0x48, 0x67);

        public static readonly Guid IID_IMFSourceReaderCallback2 = new Guid(0xCF839FE6, 0x8C2A, 0x4DD2, 0xB6, 0xEA, 0xC2, 0x2D, 0x69, 0x61, 0xAF, 0x05);

        public static readonly Guid CLSID_MFSinkWriter = new Guid(0xA3BBFB17, 0x8273, 0x4E52, 0x9E, 0x0E, 0x97, 0x39, 0xDC, 0x88, 0x79, 0x90);

        public static readonly Guid MF_SINK_WRITER_ASYNC_CALLBACK = new Guid(0x48CB183E, 0x7B0B, 0x46F4, 0x82, 0x2E, 0x5E, 0x1D, 0x2D, 0xDA, 0x43, 0x54);

        public static readonly Guid MF_SINK_WRITER_DISABLE_THROTTLING = new Guid(0x08B845D8, 0x2B74, 0x4AFE, 0x9D, 0x53, 0xBE, 0x16, 0xD2, 0xD5, 0xAE, 0x4F);

        public static readonly Guid MF_SINK_WRITER_D3D_MANAGER = new Guid(0xEC822DA2, 0xE1E9, 0x4B29, 0xA0, 0xD8, 0x56, 0x3C, 0x71, 0x9F, 0x52, 0x69);

        public static readonly Guid MF_SINK_WRITER_ENCODER_CONFIG = new Guid(0xAD91CD04, 0xA7CC, 0x4AC7, 0x99, 0xB6, 0xA5, 0x7B, 0x9A, 0x4A, 0x7C, 0x70);

        public static readonly Guid IID_IMFSinkWriter = new Guid(0x3137F1CD, 0xFE5E, 0x4805, 0xA5, 0xD8, 0xFB, 0x47, 0x74, 0x48, 0xCB, 0x3D);

        public static readonly Guid IID_IMFSinkWriterEx = new Guid(0x588D72AB, 0x5BC1, 0x496A, 0x87, 0x14, 0xB7, 0x06, 0x17, 0x14, 0x1B, 0x25);

        public static readonly Guid IID_IMFSinkWriterEncoderConfig = new Guid(0x17C3779E, 0x3CDE, 0x4EDE, 0x8C, 0x60, 0x38, 0x99, 0xF5, 0xF5, 0x3A, 0xD6);

        public static readonly Guid IID_IMFSinkWriterCallback = new Guid(0x666F76DE, 0x33D2, 0x41B9, 0xA4, 0x58, 0x29, 0xED, 0x0A, 0x97, 0x2C, 0x58);

        public static readonly Guid IID_IMFSinkWriterCallback2 = new Guid(0x2456BD58, 0xC067, 0x4513, 0x84, 0xFE, 0x8D, 0x0C, 0x88, 0xFF, 0xDC, 0x61);

        public static readonly Guid MF_READWRITE_DISABLE_CONVERTERS = new Guid(0x98D5B065, 0x1374, 0x4847, 0x8D, 0x5D, 0x31, 0x52, 0x0F, 0xEE, 0x71, 0x56);

        public static readonly Guid MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS = new Guid(0xA634A91C, 0x822B, 0x41B9, 0xA4, 0x94, 0x4D, 0xE4, 0x64, 0x36, 0x12, 0xB0);

        public static readonly Guid MF_READWRITE_MMCSS_CLASS = new Guid(0x39384300, 0xD0EB, 0x40B1, 0x87, 0xA0, 0x33, 0x18, 0x87, 0x1B, 0x5A, 0x53);

        public static readonly Guid MF_READWRITE_MMCSS_PRIORITY = new Guid(0x43AD19CE, 0xF33F, 0x4BA9, 0xA5, 0x80, 0xE4, 0xCD, 0x12, 0xF2, 0xD1, 0x44);

        public static readonly Guid MF_READWRITE_MMCSS_CLASS_AUDIO = new Guid(0x430847DA, 0x0890, 0x4B0E, 0x93, 0x8C, 0x05, 0x43, 0x32, 0xC5, 0x47, 0xE1);

        public static readonly Guid MF_READWRITE_MMCSS_PRIORITY_AUDIO = new Guid(0x273DB885, 0x2DE2, 0x4DB2, 0xA6, 0xA7, 0xFD, 0xB6, 0x6F, 0xB4, 0x0B, 0x61);

        public static readonly Guid MF_READWRITE_D3D_OPTIONAL = new Guid(0x216479D9, 0x3071, 0x42CA, 0xBB, 0x6C, 0x4C, 0x22, 0x10, 0x2E, 0x1D, 0x18);

        public static readonly Guid MF_MEDIASINK_AUTOFINALIZE_SUPPORTED = new Guid(0x48C131BE, 0x135A, 0x41CB, 0x82, 0x90, 0x03, 0x65, 0x25, 0x09, 0xC9, 0x99);

        public static readonly Guid MF_MEDIASINK_ENABLE_AUTOFINALIZE = new Guid(0x34014265, 0xCB7E, 0x4CDE, 0xAC, 0x7C, 0xEF, 0xFD, 0x3B, 0x3C, 0x25, 0x30);

        public static readonly Guid MF_READWRITE_ENABLE_AUTOFINALIZE = new Guid(0xDD7CA129, 0x8CD1, 0x4DC5, 0x9D, 0xDE, 0xCE, 0x16, 0x86, 0x75, 0xDE, 0x61);
    }
}