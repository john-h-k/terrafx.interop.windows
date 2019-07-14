// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Typeface classification values, used for font selection and matching.</summary>
    /// <remarks> Note the family type (index 0) is the only stable entry in the 10-byte array, as all the following entries can change dynamically depending on context of the first field.</remarks>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct DWRITE_PANOSE
    {
        #region Fields
        [FieldOffset(0)]
        [NativeTypeName("UINT8[10]")]
        public fixed byte values[10];

        [FieldOffset(0)]
        [NativeTypeName("UINT8")]
        public byte familyKind;

        [FieldOffset(0)]
        public _text_e__Struct text;

        [FieldOffset(0)]
        public _script_e__Struct script;

        [FieldOffset(0)]
        public _decorative_e__Struct decorative;

        [FieldOffset(0)]
        public _symbol_e__Struct symbol;
        #endregion

        #region Structs
        public struct _text_e__Struct
        {
            #region Fields
            [NativeTypeName("UINT8")]
            public byte familyKind;

            [NativeTypeName("UINT8")]
            public byte serifStyle;

            [NativeTypeName("UINT8")]
            public byte weight;

            [NativeTypeName("UINT8")]
            public byte proportion;

            [NativeTypeName("UINT8")]
            public byte contrast;

            [NativeTypeName("UINT8")]
            public byte strokeVariation;

            [NativeTypeName("UINT8")]
            public byte armStyle;

            [NativeTypeName("UINT8")]
            public byte letterform;

            [NativeTypeName("UINT8")]
            public byte midline;

            [NativeTypeName("UINT8")]
            public byte xHeight;
            #endregion
        };

        public struct _script_e__Struct
        {
            #region Fields
            [NativeTypeName("UINT8")]
            public byte familyKind;

            [NativeTypeName("UINT8")]
            public byte toolKind;

            [NativeTypeName("UINT8")]
            public byte weight;

            [NativeTypeName("UINT8")]
            public byte spacing;

            [NativeTypeName("UINT8")]
            public byte aspectRatio;

            [NativeTypeName("UINT8")]
            public byte contrast;

            [NativeTypeName("UINT8")]
            public byte scriptTopology;

            [NativeTypeName("UINT8")]
            public byte scriptForm;

            [NativeTypeName("UINT8")]
            public byte finials;

            [NativeTypeName("UINT8")]
            public byte xAscent;
            #endregion
        }

        public struct _decorative_e__Struct
        {
            #region Fields
            [NativeTypeName("UINT8")]
            public byte familyKind;

            [NativeTypeName("UINT8")]
            public byte decorativeClass;

            [NativeTypeName("UINT8")]
            public byte weight;

            [NativeTypeName("UINT8")]
            public byte aspect;

            [NativeTypeName("UINT8")]
            public byte contrast;

            [NativeTypeName("UINT8")]
            public byte serifVariant;

            [NativeTypeName("UINT8")]
            public byte fill;

            [NativeTypeName("UINT8")]
            public byte lining;

            [NativeTypeName("UINT8")]
            public byte decorativeTopology;

            [NativeTypeName("UINT8")]
            public byte characterRange;
            #endregion
        }

        public struct _symbol_e__Struct
        {
            #region Fields
            [NativeTypeName("UINT8")]
            public byte familyKind;

            [NativeTypeName("UINT8")]
            public byte symbolKind;

            [NativeTypeName("UINT8")]
            public byte weight;

            [NativeTypeName("UINT8")]
            public byte spacing;

            [NativeTypeName("UINT8")]
            public byte aspectRatioAndContrast;

            [NativeTypeName("UINT8")]
            public byte aspectRatio94;

            [NativeTypeName("UINT8")]
            public byte aspectRatio119;

            [NativeTypeName("UINT8")]
            public byte aspectRatio157;

            [NativeTypeName("UINT8")]
            public byte aspectRatio163;

            [NativeTypeName("UINT8")]
            public byte aspectRatio211;
            #endregion
        }
        #endregion
    }
}