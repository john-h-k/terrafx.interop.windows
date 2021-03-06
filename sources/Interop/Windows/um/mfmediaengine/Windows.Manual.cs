// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IMFMediaError = new Guid(0xFC0E10D2, 0xAB2A, 0x4501, 0xA9, 0x51, 0x06, 0xBB, 0x10, 0x75, 0x18, 0x4C);

        public static readonly Guid IID_IMFMediaTimeRange = new Guid(0xDB71A2FC, 0x078A, 0x414E, 0x9D, 0xF9, 0x8C, 0x25, 0x31, 0xB0, 0xAA, 0x6C);

        public static readonly Guid IID_IMFMediaEngineNotify = new Guid(0xFEE7C112, 0xE776, 0x42B5, 0x9B, 0xBF, 0x00, 0x48, 0x52, 0x4E, 0x2B, 0xD5);

        public static readonly Guid IID_IMFMediaEngineSrcElements = new Guid(0x7A5E5354, 0xB114, 0x4C72, 0xB9, 0x91, 0x31, 0x31, 0xD7, 0x50, 0x32, 0xEA);

        public static readonly Guid IID_IMFMediaEngine = new Guid(0x98A1B0BB, 0x03EB, 0x4935, 0xAE, 0x7C, 0x93, 0xC1, 0xFA, 0x0E, 0x1C, 0x93);

        public static readonly Guid IID_IMFMediaEngineEx = new Guid(0x83015EAD, 0xB1E6, 0x40D0, 0xA9, 0x8A, 0x37, 0x14, 0x5F, 0xFE, 0x1A, 0xD1);

        public static readonly Guid IID_IMFMediaEngineAudioEndpointId = new Guid(0x7A3BAC98, 0x0E76, 0x49FB, 0x8C, 0x20, 0x8A, 0x86, 0xFD, 0x98, 0xEA, 0xF2);

        public static readonly Guid IID_IMFMediaEngineExtension = new Guid(0x2F69D622, 0x20B5, 0x41E9, 0xAF, 0xDF, 0x89, 0xCE, 0xD1, 0xDD, 0xA0, 0x4E);

        public static readonly Guid IID_IMFMediaEngineProtectedContent = new Guid(0x9F8021E8, 0x9C8C, 0x487E, 0xBB, 0x5C, 0x79, 0xAA, 0x47, 0x79, 0x93, 0x8C);

        public static readonly Guid IID_IAudioSourceProvider = new Guid(0xEBBAF249, 0xAFC2, 0x4582, 0x91, 0xC6, 0xB6, 0x0D, 0xF2, 0xE8, 0x49, 0x54);

        public static readonly Guid IID_IMFMediaEngineWebSupport = new Guid(0xBA2743A1, 0x07E0, 0x48EF, 0x84, 0xB6, 0x9A, 0x2E, 0xD0, 0x23, 0xCA, 0x6C);

        public static readonly Guid IID_IMFMediaSourceExtensionNotify = new Guid(0xA7901327, 0x05DD, 0x4469, 0xA7, 0xB7, 0x0E, 0x01, 0x97, 0x9E, 0x36, 0x1D);

        public static readonly Guid IID_IMFBufferListNotify = new Guid(0x24CD47F7, 0x81D8, 0x4785, 0xAD, 0xB2, 0xAF, 0x69, 0x7A, 0x96, 0x3C, 0xD2);

        public static readonly Guid IID_IMFSourceBufferNotify = new Guid(0x87E47623, 0x2CEB, 0x45D6, 0x9B, 0x88, 0xD8, 0x52, 0x0C, 0x4D, 0xCB, 0xBC);

        public static readonly Guid IID_IMFSourceBuffer = new Guid(0xE2CD3A4B, 0xAF25, 0x4D3D, 0x91, 0x10, 0xDA, 0x0E, 0x6F, 0x8E, 0xE8, 0x77);

        public static readonly Guid IID_IMFSourceBufferAppendMode = new Guid(0x19666FB4, 0xBABE, 0x4C55, 0xBC, 0x03, 0x0A, 0x07, 0x4D, 0xA3, 0x7E, 0x2A);

        public static readonly Guid IID_IMFSourceBufferList = new Guid(0x249981F8, 0x8325, 0x41F3, 0xB8, 0x0C, 0x3B, 0x9E, 0x3A, 0xAD, 0x0C, 0xBE);

        public static readonly Guid IID_IMFMediaSourceExtension = new Guid(0xE467B94E, 0xA713, 0x4562, 0xA8, 0x02, 0x81, 0x6A, 0x42, 0xE9, 0x00, 0x8A);

        public static readonly Guid IID_IMFMediaSourceExtensionLiveSeekableRange = new Guid(0x5D1ABFD6, 0x450A, 0x4D92, 0x9E, 0xFC, 0xD6, 0xB6, 0xCB, 0xC1, 0xF4, 0xDA);

        public static readonly Guid IID_IMFMediaEngineEME = new Guid(0x50DC93E4, 0xBA4F, 0x4275, 0xAE, 0x66, 0x83, 0xE8, 0x36, 0xE5, 0x74, 0x69);

        public static readonly Guid IID_IMFMediaEngineSrcElementsEx = new Guid(0x654A6BB3, 0xE1A3, 0x424A, 0x99, 0x08, 0x53, 0xA4, 0x3A, 0x0D, 0xFD, 0xA0);

        public static readonly Guid IID_IMFMediaEngineNeedKeyNotify = new Guid(0x46A30204, 0xA696, 0x4B18, 0x88, 0x04, 0x24, 0x6B, 0x8F, 0x03, 0x1B, 0xB1);

        public static readonly Guid IID_IMFMediaKeys = new Guid(0x5CB31C05, 0x61FF, 0x418F, 0xAF, 0xDA, 0xCA, 0xAF, 0x41, 0x42, 0x1A, 0x38);

        public static readonly Guid IID_IMFMediaKeySession = new Guid(0x24FA67D5, 0xD1D0, 0x4DC5, 0x99, 0x5C, 0xC0, 0xEF, 0xDC, 0x19, 0x1F, 0xB5);

        public static readonly Guid IID_IMFMediaKeySessionNotify = new Guid(0x6A0083F9, 0x8947, 0x4C1D, 0x9C, 0xE0, 0xCD, 0xEE, 0x22, 0xB2, 0x31, 0x35);

        public static readonly Guid IID_IMFCdmSuspendNotify = new Guid(0x7A5645D2, 0x43BD, 0x47FD, 0x87, 0xB7, 0xDC, 0xD2, 0x4C, 0xC7, 0xD6, 0x92);

        public static readonly Guid IID_IMFHDCPStatus = new Guid(0xDE400F54, 0x5BF1, 0x40CF, 0x89, 0x64, 0x0B, 0xEA, 0x13, 0x6B, 0x1E, 0x3D);

        public static readonly Guid IID_IMFMediaEngineOPMInfo = new Guid(0x765763E6, 0x6C01, 0x4B01, 0xBB, 0x0F, 0xB8, 0x29, 0xF6, 0x0E, 0xD2, 0x8C);

        public static readonly Guid IID_IMFMediaEngineClassFactory = new Guid(0x4D645ACE, 0x26AA, 0x4688, 0x9B, 0xE1, 0xDF, 0x35, 0x16, 0x99, 0x0B, 0x93);

        public static readonly Guid IID_IMFMediaEngineClassFactoryEx = new Guid(0xC56156C6, 0xEA5B, 0x48A5, 0x9D, 0xF8, 0xFB, 0xE0, 0x35, 0xD0, 0x92, 0x9E);

        public static readonly Guid IID_IMFMediaEngineClassFactory2 = new Guid(0x09083CEF, 0x867F, 0x4BF6, 0x87, 0x76, 0xDE, 0xE3, 0xA7, 0xB4, 0x2F, 0xCA);

        public static readonly Guid IID_IMFExtendedDRMTypeSupport = new Guid(0x332EC562, 0x3758, 0x468D, 0xA7, 0x84, 0xE3, 0x8F, 0x23, 0x55, 0x21, 0x28);

        public static readonly Guid IID_IMFMediaEngineSupportsSourceTransfer = new Guid(0xA724B056, 0x1B2E, 0x4642, 0xA6, 0xF3, 0xDB, 0x94, 0x20, 0xC5, 0x29, 0x08);

        public static readonly Guid IID_IMFMediaEngineTransferSource = new Guid(0x24230452, 0xFE54, 0x40CC, 0x94, 0xF3, 0xFC, 0xC3, 0x94, 0xC3, 0x40, 0xD6);

        public static readonly Guid IID_IMFTimedText = new Guid(0x1F2A94C9, 0xA3DF, 0x430D, 0x9D, 0x0F, 0xAC, 0xD8, 0x5D, 0xDC, 0x29, 0xAF);

        public static readonly Guid IID_IMFTimedTextNotify = new Guid(0xDF6B87B6, 0xCE12, 0x45DB, 0xAB, 0xA7, 0x43, 0x2F, 0xE0, 0x54, 0xE5, 0x7D);

        public static readonly Guid IID_IMFTimedTextTrack = new Guid(0x8822C32D, 0x654E, 0x4233, 0xBF, 0x21, 0xD7, 0xF2, 0xE6, 0x7D, 0x30, 0xD4);

        public static readonly Guid IID_IMFTimedTextTrackList = new Guid(0x23FF334C, 0x442C, 0x445F, 0xBC, 0xCC, 0xED, 0xC4, 0x38, 0xAA, 0x11, 0xE2);

        public static readonly Guid IID_IMFTimedTextCue = new Guid(0x1E560447, 0x9A2B, 0x43E1, 0xA9, 0x4C, 0xB0, 0xAA, 0xAB, 0xFB, 0xFB, 0xC9);

        public static readonly Guid IID_IMFTimedTextFormattedText = new Guid(0xE13AF3C1, 0x4D47, 0x4354, 0xB1, 0xF5, 0xE8, 0x3A, 0xE0, 0xEC, 0xAE, 0x60);

        public static readonly Guid IID_IMFTimedTextStyle = new Guid(0x09B2455D, 0xB834, 0x4F01, 0xA3, 0x47, 0x90, 0x52, 0xE2, 0x1C, 0x45, 0x0E);

        public static readonly Guid IID_IMFTimedTextRegion = new Guid(0xC8D22AFC, 0xBC47, 0x4BDF, 0x9B, 0x04, 0x78, 0x7E, 0x49, 0xCE, 0x3F, 0x58);

        public static readonly Guid IID_IMFTimedTextBinary = new Guid(0x4AE3A412, 0x0545, 0x43C4, 0xBF, 0x6F, 0x6B, 0x97, 0xA5, 0xC6, 0xC4, 0x32);

        public static readonly Guid IID_IMFTimedTextCueList = new Guid(0xAD128745, 0x211B, 0x40A0, 0x99, 0x81, 0xFE, 0x65, 0xF1, 0x66, 0xD0, 0xFD);

        public static readonly Guid IID_IMFMediaEngineEMENotify = new Guid(0x9E184D15, 0xCDB7, 0x4F86, 0xB4, 0x9E, 0x56, 0x66, 0x89, 0xF4, 0xA6, 0x01);

        public static readonly Guid IID_IMFMediaKeySessionNotify2 = new Guid(0xC3A9E92A, 0xDA88, 0x46B0, 0xA1, 0x10, 0x6C, 0xF9, 0x53, 0x02, 0x6C, 0xB9);

        public static readonly Guid IID_IMFMediaKeySystemAccess = new Guid(0xAEC63FDA, 0x7A97, 0x4944, 0xB3, 0x5C, 0x6C, 0x6D, 0xF8, 0x08, 0x5C, 0xC3);

        public static readonly Guid IID_IMFMediaEngineClassFactory3 = new Guid(0x3787614F, 0x65F7, 0x4003, 0xB6, 0x73, 0xEA, 0xD8, 0x29, 0x3A, 0x0E, 0x60);

        public static readonly Guid IID_IMFMediaKeys2 = new Guid(0x45892507, 0xAD66, 0x4DE2, 0x83, 0xA2, 0xAC, 0xBB, 0x13, 0xCD, 0x8D, 0x43);

        public static readonly Guid IID_IMFMediaKeySession2 = new Guid(0xE9707E05, 0x6D55, 0x4636, 0xB1, 0x85, 0x3D, 0xE2, 0x12, 0x10, 0xBD, 0x75);

        public static readonly Guid IID_IMFMediaEngineClassFactory4 = new Guid(0xFBE256C1, 0x43CF, 0x4A9B, 0x8C, 0xB8, 0xCE, 0x86, 0x32, 0xA3, 0x41, 0x86);
    }
}
