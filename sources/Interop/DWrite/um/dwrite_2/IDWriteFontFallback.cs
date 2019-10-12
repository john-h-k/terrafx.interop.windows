// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A font fallback definition used for mapping characters to fonts capable of supporting them.</summary>
    [Guid("EFA008F9-F7A1-48BF-B05C-F224713CC0FF")]
    public unsafe partial struct IDWriteFontFallback
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFallback* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFallback* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFallback* This);

        /// <summary>Determines an appropriate font to use to render the range of text.</summary>
        /// <param name="analysisSource">The text source implementation holds the text and locale.</param>
        /// <param name="textLength">Length of the text to analyze.</param>
        /// <param name="baseFontCollection">Default font collection to use.</param>
        /// <param name="baseFamilyName">Family name of the base font. If you pass null, no matching will be done against the family.</param>
        /// <param name="baseWeight">Desired weight.</param>
        /// <param name="baseStyle">Desired style.</param>
        /// <param name="baseStretch">Desired stretch.</param>
        /// <param name="mappedLength">Length of text mapped to the mapped font. This will always be less or equal to the input text length and greater than zero (if the text length is non-zero) so that the caller advances at least one character each call.</param>
        /// <param name="mappedFont">The font that should be used to render the first mappedLength characters of the text. If it returns NULL, then no known font can render the text, and mappedLength is the number of unsupported characters to skip.</param>
        /// <param name="scale">Scale factor to multiply the em size of the returned font by.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapCharacters(IDWriteFontFallback* This, IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [Optional] IDWriteFontCollection* baseFontCollection, [Optional, NativeTypeName("WCHAR[]")] ushort* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, [NativeTypeName("UINT32")] uint* mappedLength, IDWriteFont** mappedFont, [NativeTypeName("FLOAT")] float* scale);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontFallback* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFallback* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFallback* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapCharacters(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [Optional] IDWriteFontCollection* baseFontCollection, [Optional, NativeTypeName("WCHAR[]")] ushort* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, [NativeTypeName("UINT32")] uint* mappedLength, IDWriteFont** mappedFont, [NativeTypeName("FLOAT")] float* scale)
        {
            fixed (IDWriteFontFallback* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MapCharacters>(lpVtbl->MapCharacters)(This, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr MapCharacters;
        }
    }
}