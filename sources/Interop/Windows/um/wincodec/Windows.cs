// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICImagingFactory1 = new Guid(0xcacaf262, 0x9370, 0x4615, 0xa1, 0x3b, 0x9f, 0x55, 0x39, 0xda, 0x4c, 0xa);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICImagingFactory2 = new Guid(0x317d06e8, 0x5f24, 0x433d, 0xbd, 0xf7, 0x79, 0xce, 0x68, 0xd8, 0xab, 0xc2);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VendorMicrosoft = new Guid(0xf0e749ca, 0xedef, 0x4589, 0xa7, 0x3a, 0xee, 0xe, 0x62, 0x6a, 0x2a, 0x2b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_VendorMicrosoftBuiltIn = new Guid(0x257a30fd, 0x6b6, 0x462b, 0xae, 0xa4, 0x63, 0xf7, 0xb, 0x86, 0xe5, 0x33);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICPngDecoder1 = new Guid(0x389ea17b, 0x5078, 0x4cde, 0xb6, 0xef, 0x25, 0xc1, 0x51, 0x75, 0xc7, 0x51);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICPngDecoder2 = new Guid(0xe018945b, 0xaa86, 0x4008, 0x9b, 0xd4, 0x67, 0x77, 0xa1, 0xe4, 0x0c, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICBmpDecoder = new Guid(0x6b462062, 0x7cbf, 0x400d, 0x9f, 0xdb, 0x81, 0x3d, 0xd1, 0x0f, 0x27, 0x78);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICIcoDecoder = new Guid(0xc61bfcdf, 0x2e0f, 0x4aad, 0xa8, 0xd7, 0xe0, 0x6b, 0xaf, 0xeb, 0xcd, 0xfe);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICJpegDecoder = new Guid(0x9456a480, 0xe88b, 0x43ea, 0x9e, 0x73, 0x0b, 0x2d, 0x9b, 0x71, 0xb1, 0xca);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICGifDecoder = new Guid(0x381dda3c, 0x9ce9, 0x4834, 0xa2, 0x3e, 0x1f, 0x98, 0xf8, 0xfc, 0x52, 0xbe);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICTiffDecoder = new Guid(0xb54e85d9, 0xfe23, 0x499f, 0x8b, 0x88, 0x6a, 0xce, 0xa7, 0x13, 0x75, 0x2b);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICWmpDecoder = new Guid(0xa26cec36, 0x234c, 0x4950, 0xae, 0x16, 0xe3, 0x4a, 0xac, 0xe7, 0x1d, 0x0d);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICDdsDecoder = new Guid(0x9053699f, 0xa341, 0x429d, 0x9e, 0x90, 0xee, 0x43, 0x7c, 0xf8, 0x0c, 0x73);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICBmpEncoder = new Guid(0x69be8bb4, 0xd66d, 0x47c8, 0x86, 0x5a, 0xed, 0x15, 0x89, 0x43, 0x37, 0x82);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICPngEncoder = new Guid(0x27949969, 0x876a, 0x41d7, 0x94, 0x47, 0x56, 0x8f, 0x6a, 0x35, 0xa4, 0xdc);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICJpegEncoder = new Guid(0x1a34f5c1, 0x4a5a, 0x46dc, 0xb6, 0x44, 0x1f, 0x45, 0x67, 0xe7, 0xa6, 0x76);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICGifEncoder = new Guid(0x114f5598, 0x0b22, 0x40a0, 0x86, 0xa1, 0xc8, 0x3e, 0xa4, 0x95, 0xad, 0xbd);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICTiffEncoder = new Guid(0x0131be10, 0x2001, 0x4c5f, 0xa9, 0xb0, 0xcc, 0x88, 0xfa, 0xb6, 0x4c, 0xe8);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICWmpEncoder = new Guid(0xac4ce3cb, 0xe1c1, 0x44cd, 0x82, 0x15, 0x5a, 0x16, 0x65, 0x50, 0x9e, 0xc2);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICDdsEncoder = new Guid(0xa61dde94, 0x66ce, 0x4ac1, 0x88, 0x1b, 0x71, 0x68, 0x05, 0x88, 0x89, 0x5e);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICAdngDecoder = new Guid(0x981d9411, 0x909e, 0x42a7, 0x8f, 0x5d, 0xa7, 0x47, 0xff, 0x05, 0x2e, 0xdb);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICJpegQualcommPhoneEncoder = new Guid(0x68ed5c62, 0xf534, 0x4979, 0xb2, 0xb3, 0x68, 0x6a, 0x12, 0xb2, 0xb3, 0x4c);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICHeifDecoder = new Guid(0xe9A4A80a, 0x44fe, 0x4DE4, 0x89, 0x71, 0x71, 0x50, 0XB1, 0X0a, 0X51, 0X99);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICHeifEncoder = new Guid(0x0dbecec1, 0x9eb3, 0x4860, 0x9c, 0x6f, 0xdd, 0xbe, 0x86, 0x63, 0x45, 0x75);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICWebpDecoder = new Guid(0x7693E886, 0x51C9, 0x4070, 0x84, 0x19, 0x9F, 0x70, 0X73, 0X8E, 0XC8, 0XFA);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICRAWDecoder = new Guid(0x41945702, 0x8302, 0x44A6, 0x94, 0x45, 0xAC, 0x98, 0xE8, 0xAF, 0xA0, 0x86);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatBmp = new Guid(0x0af1d87e, 0xfcfe, 0x4188, 0xbd, 0xeb, 0xa7, 0x90, 0x64, 0x71, 0xcb, 0xe3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatPng = new Guid(0x1b7cfaf4, 0x713f, 0x473c, 0xbb, 0xcd, 0x61, 0x37, 0x42, 0x5f, 0xae, 0xaf);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatIco = new Guid(0xa3a860c4, 0x338f, 0x4c17, 0x91, 0x9a, 0xfb, 0xa4, 0xb5, 0x62, 0x8f, 0x21);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatJpeg = new Guid(0x19e4a5aa, 0x5662, 0x4fc5, 0xa0, 0xc0, 0x17, 0x58, 0x02, 0x8e, 0x10, 0x57);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatTiff = new Guid(0x163bcc30, 0xe2e9, 0x4f0b, 0x96, 0x1d, 0xa3, 0xe9, 0xfd, 0xb7, 0x88, 0xa3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatGif = new Guid(0x1f8a5601, 0x7d4d, 0x4cbd, 0x9c, 0x82, 0x1b, 0xc8, 0xd4, 0xee, 0xb9, 0xa5);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatWmp = new Guid(0x57a37caa, 0x367a, 0x4540, 0x91, 0x6b, 0xf1, 0x83, 0xc5, 0x09, 0x3a, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatDds = new Guid(0x9967cb95, 0x2e85, 0x4ac8, 0x8c, 0xa2, 0x83, 0xd7, 0xcc, 0xd4, 0x25, 0xc9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatAdng = new Guid(0xf3ff6d0d, 0x38c0, 0x41c4, 0xb1, 0xfe, 0x1f, 0x38, 0x24, 0xf1, 0x7b, 0x84);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatHeif = new Guid(0xe1e62521, 0x6787, 0x405b, 0xa3, 0x39, 0x50, 0x07, 0x15, 0xb5, 0x76, 0x3f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatWebp = new Guid(0xe094b0e2, 0x67f2, 0x45b3, 0xb0, 0xea, 0x11, 0x53, 0x37, 0xca, 0x7c, 0xf3);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_ContainerFormatRaw = new Guid(0xfe99ce60, 0xf19c, 0x433c, 0xa3, 0xae, 0x00, 0xac, 0xef, 0xa9, 0xca, 0x21);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICImagingCategories = new Guid(0xfae3d380, 0xfea4, 0x4623, 0x8c, 0x75, 0xc6, 0xb6, 0x11, 0x10, 0xb6, 0x81);

        [NativeTypeName("const GUID")]
        public static readonly Guid CATID_WICBitmapDecoders = new Guid(0x7ed96837, 0x96f0, 0x4812, 0xb2, 0x11, 0xf1, 0x3c, 0x24, 0x11, 0x7e, 0xd3);

        [NativeTypeName("const GUID")]
        public static readonly Guid CATID_WICBitmapEncoders = new Guid(0xac757296, 0x3522, 0x4e11, 0x98, 0x62, 0xc1, 0x7b, 0xe5, 0xa1, 0x76, 0x7e);

        [NativeTypeName("const GUID")]
        public static readonly Guid CATID_WICPixelFormats = new Guid(0x2b46e70f, 0xcda7, 0x473e, 0x89, 0xf6, 0xdc, 0x96, 0x30, 0xa2, 0x39, 0x0b);

        [NativeTypeName("const GUID")]
        public static readonly Guid CATID_WICFormatConverters = new Guid(0x7835eae8, 0xbf14, 0x49d1, 0x93, 0xce, 0x53, 0x3a, 0x40, 0x7b, 0x22, 0x48);

        [NativeTypeName("const GUID")]
        public static readonly Guid CATID_WICMetadataReader = new Guid(0x05af94d8, 0x7174, 0x4cd2, 0xbe, 0x4a, 0x41, 0x24, 0xb8, 0x0e, 0xe4, 0xb8);

        [NativeTypeName("const GUID")]
        public static readonly Guid CATID_WICMetadataWriter = new Guid(0xabe3b9a4, 0x257d, 0x4b97, 0xbd, 0x1a, 0x29, 0x4a, 0xf4, 0x96, 0x22, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICDefaultFormatConverter = new Guid(0x1a3f11dc, 0xb514, 0x4b17, 0x8c, 0x5f, 0x21, 0x54, 0x51, 0x38, 0x52, 0xf1);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICFormatConverterHighColor = new Guid(0xac75d454, 0x9f37, 0x48f8, 0xb9, 0x72, 0x4e, 0x19, 0xbc, 0x85, 0x60, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICFormatConverterNChannel = new Guid(0xc17cabb2, 0xd4a3, 0x47d7, 0xa5, 0x57, 0x33, 0x9b, 0x2e, 0xfb, 0xd4, 0xf1);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICFormatConverterWMPhoto = new Guid(0x9cb5172b, 0xd600, 0x46ba, 0xab, 0x77, 0x77, 0xbb, 0x7e, 0x3a, 0x00, 0xd9);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_WICPlanarFormatConverter = new Guid(0x184132b8, 0x32f8, 0x4784, 0x91, 0x31, 0xdd, 0x72, 0x24, 0xb2, 0x34, 0x38);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormatDontCare = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x00);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat1bppIndexed = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x01);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat2bppIndexed = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x02);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat4bppIndexed = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x03);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat8bppIndexed = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x04);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormatBlackWhite = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x05);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat2bppGray = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x06);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat4bppGray = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x07);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat8bppGray = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x08);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat8bppAlpha = new Guid(0xe6cd0116, 0xeeba, 0x4161, 0xaa, 0x85, 0x27, 0xdd, 0x9f, 0xb3, 0xa8, 0x95);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppBGR555 = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x09);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppBGR565 = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0a);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppBGRA5551 = new Guid(0x05ec7c2b, 0xf1e6, 0x4961, 0xad, 0x46, 0xe1, 0xcc, 0x81, 0x0a, 0x87, 0xd2);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppGray = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat24bppBGR = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat24bppRGB = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppBGR = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppBGRA = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppPBGRA = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x10);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppGrayFloat = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppRGB = new Guid(0xd98c6b95, 0x3efe, 0x47d6, 0xbb, 0x25, 0xeb, 0x17, 0x48, 0xab, 0x0c, 0xf1);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppRGBA = new Guid(0xf5c7ad2d, 0x6a8d, 0x43dd, 0xa7, 0xa8, 0xa2, 0x99, 0x35, 0x26, 0x1a, 0xe9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppPRGBA = new Guid(0x3cc4a650, 0xa527, 0x4d37, 0xa9, 0x16, 0x31, 0x42, 0xc7, 0xeb, 0xed, 0xba);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bppRGB = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x15);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bppBGR = new Guid(0xe605a384, 0xb468, 0x46ce, 0xbb, 0x2e, 0x36, 0xf1, 0x80, 0xe6, 0x43, 0x13);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppRGB = new Guid(0xa1182111, 0x186d, 0x4d42, 0xbc, 0x6a, 0x9c, 0x83, 0x03, 0xa8, 0xdf, 0xf9);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppRGBA = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x16);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppBGRA = new Guid(0x1562ff7c, 0xd352, 0x46f9, 0x97, 0x9e, 0x42, 0x97, 0x6b, 0x79, 0x22, 0x46);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppPRGBA = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppPBGRA = new Guid(0x8c518e8e, 0xa4ec, 0x468b, 0xae, 0x70, 0xc9, 0xa3, 0x5a, 0x9c, 0x55, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppGrayFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x13);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppBGR101010 = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x14);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bppRGBFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x12);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bppBGRFixedPoint = new Guid(0x49ca140e, 0xcab6, 0x493b, 0x9d, 0xdf, 0x60, 0x18, 0x7c, 0x37, 0x53, 0x2a);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat96bppRGBFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x18);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat96bppRGBFloat = new Guid(0xe3fed78f, 0xe8db, 0x4acf, 0x84, 0xc1, 0xe9, 0x7f, 0x61, 0x36, 0xb3, 0x27);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bppRGBAFloat = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x19);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bppPRGBAFloat = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1a);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bppRGBFloat = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppCMYK = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppRGBAFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppBGRAFixedPoint = new Guid(0x356de33c, 0x54d2, 0x4a23, 0xbb, 0x4, 0x9b, 0x7b, 0xf9, 0xb1, 0xd4, 0x2d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppRGBFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x40);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bppRGBAFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bppRGBFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppRGBAHalf = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3a);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppPRGBAHalf = new Guid(0x58ad26c2, 0xc623, 0x4d9d, 0xb3, 0x20, 0x38, 0x7e, 0x49, 0xf8, 0xc4, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppRGBHalf = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bppRGBHalf = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppRGBE = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppGrayHalf = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppGrayFixedPoint = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppRGBA1010102 = new Guid(0x25238D72, 0xFCF9, 0x4522, 0xb5, 0x14, 0x55, 0x78, 0xe5, 0xad, 0x55, 0xe0);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppRGBA1010102XR = new Guid(0x00DE6B9A, 0xC101, 0x434b, 0xb5, 0x02, 0xd0, 0x16, 0x5e, 0xe1, 0x12, 0x2c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppR10G10B10A2 = new Guid(0x604e1bb5, 0x8a3c, 0x4b65, 0xb1, 0x1c, 0xbc, 0x0b, 0x8d, 0xd7, 0x5b, 0x7f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bppR10G10B10A2HDR10 = new Guid(0x9c215c5d, 0x1acc, 0x4f0e, 0xa4, 0xbc, 0x70, 0xfb, 0x3a, 0xe8, 0xfd, 0x28);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bppCMYK = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat24bpp3Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bpp4Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x21);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat40bpp5Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x22);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bpp6Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x23);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat56bpp7Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x24);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bpp8Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x25);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bpp3Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x26);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bpp4Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x27);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat80bpp5Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x28);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat96bpp6Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x29);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat112bpp7Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2a);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bpp8Channels = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat40bppCMYKAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2c);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat80bppCMYKAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2d);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat32bpp3ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat40bpp4ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2f);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat48bpp5ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat56bpp6ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bpp7ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x32);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat72bpp8ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x33);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat64bpp3ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x34);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat80bpp4ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x35);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat96bpp5ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat112bpp6ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat128bpp7ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x38);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat144bpp8ChannelsAlpha = new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x39);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat8bppY = new Guid(0x91B4DB54, 0x2DF9, 0x42F0, 0xB4, 0x49, 0x29, 0x09, 0xBB, 0x3D, 0xF8, 0x8E);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat8bppCb = new Guid(0x1339F224, 0x6BFE, 0x4C3E, 0x93, 0x02, 0xE4, 0xF3, 0xA6, 0xD0, 0xCA, 0x2A);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat8bppCr = new Guid(0xB8145053, 0x2116, 0x49F0, 0x88, 0x35, 0xED, 0x84, 0x4B, 0x20, 0x5C, 0x51);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppCbCr = new Guid(0xFF95BA6E, 0x11E0, 0x4263, 0xBB, 0x45, 0x01, 0x72, 0x1F, 0x34, 0x60, 0xA4);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppYQuantizedDctCoefficients = new Guid(0xA355F433, 0x48E8, 0x4A42, 0x84, 0xD8, 0xE2, 0xAA, 0x26, 0xCA, 0x80, 0xA4);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppCbQuantizedDctCoefficients = new Guid(0xD2C4FF61, 0x56A5, 0x49C2, 0x8B, 0x5C, 0x4C, 0x19, 0x25, 0x96, 0x48, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_WICPixelFormat16bppCrQuantizedDctCoefficients = new Guid(0x2FE354F0, 0x1680, 0x42D8, 0x92, 0x31, 0xE7, 0x3C, 0x05, 0x65, 0xBF, 0xC1);

        [DllImport("WindowsCodecs", EntryPoint = "WICConvertBitmapSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICConvertBitmapSource([NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISrc, [NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIDst);

        [DllImport("WindowsCodecs", EntryPoint = "WICCreateBitmapFromSection", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICCreateBitmapFromSection([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("UINT")] uint stride, [NativeTypeName("UINT")] uint offset, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [DllImport("WindowsCodecs", EntryPoint = "WICCreateBitmapFromSectionEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICCreateBitmapFromSectionEx([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("HANDLE")] IntPtr hSection, [NativeTypeName("UINT")] uint stride, [NativeTypeName("UINT")] uint offset, WICSectionAccessLevel desiredAccessLevel, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [DllImport("WindowsCodecs", EntryPoint = "WICMapGuidToShortName", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapGuidToShortName([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint cchName, [NativeTypeName("WCHAR *")] ushort* wzName, [NativeTypeName("UINT *")] uint* pcchActual);

        [DllImport("WindowsCodecs", EntryPoint = "WICMapShortNameToGuid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapShortNameToGuid([NativeTypeName("PCWSTR")] ushort* wzName, [NativeTypeName("GUID *")] Guid* pguid);

        [DllImport("WindowsCodecs", EntryPoint = "WICMapSchemaToName", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapSchemaToName([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("LPWSTR")] ushort* pwzSchema, [NativeTypeName("UINT")] uint cchName, [NativeTypeName("WCHAR *")] ushort* wzName, [NativeTypeName("UINT *")] uint* pcchActual);

        [NativeTypeName("#define WINCODEC_SDK_VERSION1 0x0236")]
        public const int WINCODEC_SDK_VERSION1 = 0x0236;

        [NativeTypeName("#define WINCODEC_SDK_VERSION2 0x0237")]
        public const int WINCODEC_SDK_VERSION2 = 0x0237;

        [NativeTypeName("#define WINCODEC_SDK_VERSION WINCODEC_SDK_VERSION2")]
        public const int WINCODEC_SDK_VERSION = 0x0237;

        [NativeTypeName("#define WIC_JPEG_MAX_COMPONENT_COUNT ( 4 )")]
        public const int WIC_JPEG_MAX_COMPONENT_COUNT = (4);

        [NativeTypeName("#define WIC_JPEG_MAX_TABLE_INDEX ( 3 )")]
        public const int WIC_JPEG_MAX_TABLE_INDEX = (3);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_ONE ( 0x11 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_ONE = (0x11);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_420 ( 0x111122 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_420 = (0x111122);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_422 ( 0x111121 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_422 = (0x111121);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_440 ( 0x111112 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_440 = (0x111112);

        [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_444 ( 0x111111 )")]
        public const int WIC_JPEG_SAMPLE_FACTORS_THREE_444 = (0x111111);

        [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_ONE ( 0 )")]
        public const int WIC_JPEG_QUANTIZATION_BASELINE_ONE = (0);

        [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_THREE ( 0x10100 )")]
        public const int WIC_JPEG_QUANTIZATION_BASELINE_THREE = (0x10100);

        [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_ONE ( 0 )")]
        public const int WIC_JPEG_HUFFMAN_BASELINE_ONE = (0);

        [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_THREE ( 0x111100 )")]
        public const int WIC_JPEG_HUFFMAN_BASELINE_THREE = (0x111100);

        [NativeTypeName("#define GUID_WICPixelFormatUndefined GUID_WICPixelFormatDontCare")]
        public static readonly Guid GUID_WICPixelFormatUndefined = GUID_WICPixelFormatDontCare;

        [NativeTypeName("#define FACILITY_WINCODEC_ERR 0x898")]
        public const int FACILITY_WINCODEC_ERR = 0x898;

        [NativeTypeName("#define WINCODEC_ERR_BASE 0x2000")]
        public const int WINCODEC_ERR_BASE = 0x2000;

        [NativeTypeName("#define WINCODEC_ERR_GENERIC_ERROR E_FAIL")]
        public const int WINCODEC_ERR_GENERIC_ERROR = unchecked((int)(0x80004005));

        [NativeTypeName("#define WINCODEC_ERR_INVALIDPARAMETER E_INVALIDARG")]
        public const int WINCODEC_ERR_INVALIDPARAMETER = unchecked((int)(0x80070057));

        [NativeTypeName("#define WINCODEC_ERR_OUTOFMEMORY E_OUTOFMEMORY")]
        public const int WINCODEC_ERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

        [NativeTypeName("#define WINCODEC_ERR_NOTIMPLEMENTED E_NOTIMPL")]
        public const int WINCODEC_ERR_NOTIMPLEMENTED = unchecked((int)(0x80004001));

        [NativeTypeName("#define WINCODEC_ERR_ABORTED E_ABORT")]
        public const int WINCODEC_ERR_ABORTED = unchecked((int)(0x80004004));

        [NativeTypeName("#define WINCODEC_ERR_ACCESSDENIED E_ACCESSDENIED")]
        public const int WINCODEC_ERR_ACCESSDENIED = unchecked((int)(0x80070005));

        [NativeTypeName("#define WINCODEC_ERR_VALUEOVERFLOW INTSAFE_E_ARITHMETIC_OVERFLOW")]
        public const int WINCODEC_ERR_VALUEOVERFLOW = unchecked((int)(0x80070216));

        [NativeTypeName("#define WICRawChangeNotification_ExposureCompensation 0x00000001")]
        public const int WICRawChangeNotification_ExposureCompensation = 0x00000001;

        [NativeTypeName("#define WICRawChangeNotification_NamedWhitePoint 0x00000002")]
        public const int WICRawChangeNotification_NamedWhitePoint = 0x00000002;

        [NativeTypeName("#define WICRawChangeNotification_KelvinWhitePoint 0x00000004")]
        public const int WICRawChangeNotification_KelvinWhitePoint = 0x00000004;

        [NativeTypeName("#define WICRawChangeNotification_RGBWhitePoint 0x00000008")]
        public const int WICRawChangeNotification_RGBWhitePoint = 0x00000008;

        [NativeTypeName("#define WICRawChangeNotification_Contrast 0x00000010")]
        public const int WICRawChangeNotification_Contrast = 0x00000010;

        [NativeTypeName("#define WICRawChangeNotification_Gamma 0x00000020")]
        public const int WICRawChangeNotification_Gamma = 0x00000020;

        [NativeTypeName("#define WICRawChangeNotification_Sharpness 0x00000040")]
        public const int WICRawChangeNotification_Sharpness = 0x00000040;

        [NativeTypeName("#define WICRawChangeNotification_Saturation 0x00000080")]
        public const int WICRawChangeNotification_Saturation = 0x00000080;

        [NativeTypeName("#define WICRawChangeNotification_Tint 0x00000100")]
        public const int WICRawChangeNotification_Tint = 0x00000100;

        [NativeTypeName("#define WICRawChangeNotification_NoiseReduction 0x00000200")]
        public const int WICRawChangeNotification_NoiseReduction = 0x00000200;

        [NativeTypeName("#define WICRawChangeNotification_DestinationColorContext 0x00000400")]
        public const int WICRawChangeNotification_DestinationColorContext = 0x00000400;

        [NativeTypeName("#define WICRawChangeNotification_ToneCurve 0x00000800")]
        public const int WICRawChangeNotification_ToneCurve = 0x00000800;

        [NativeTypeName("#define WICRawChangeNotification_Rotation 0x00001000")]
        public const int WICRawChangeNotification_Rotation = 0x00001000;

        [NativeTypeName("#define WICRawChangeNotification_RenderMode 0x00002000")]
        public const int WICRawChangeNotification_RenderMode = 0x00002000;
    }
}
