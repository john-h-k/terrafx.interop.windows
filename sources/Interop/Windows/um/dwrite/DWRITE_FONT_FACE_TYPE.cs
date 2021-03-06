// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_FONT_FACE_TYPE
    {
        DWRITE_FONT_FACE_TYPE_CFF,
        DWRITE_FONT_FACE_TYPE_TRUETYPE,
        DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION,
        DWRITE_FONT_FACE_TYPE_TYPE1,
        DWRITE_FONT_FACE_TYPE_VECTOR,
        DWRITE_FONT_FACE_TYPE_BITMAP,
        DWRITE_FONT_FACE_TYPE_UNKNOWN,
        DWRITE_FONT_FACE_TYPE_RAW_CFF,
        DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION = DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION,
    }
}
