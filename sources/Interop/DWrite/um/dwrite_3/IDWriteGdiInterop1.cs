// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The GDI interop interface provides interoperability with GDI.</summary>
    [Guid("4556BE70-3ABD-4F70-90BE-421780A6F515")]
    public unsafe partial struct IDWriteGdiInterop1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteGdiInterop1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteGdiInterop1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteGdiInterop1* This);

        /// <summary>Creates a font object that matches the properties specified by the LOGFONT public partial structure in the system font collection (GetSystemFontCollection).</summary>
        /// <param name="logFont">Structure containing a GDI-compatible font description.</param>
        /// <param name="font">Receives a newly created font object if successful, or NULL in case of error.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFromLOGFONT(IDWriteGdiInterop1* This, LOGFONT* logFont, IDWriteFont** font);

        /// <summary>Initializes a LOGFONT public partial structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <param name="isSystemFont">Contains TRUE if the specified font object is part of the system font collection or FALSE otherwise.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConvertFontToLOGFONT(IDWriteGdiInterop1* This, IDWriteFont* font, LOGFONT* logFont, [NativeTypeName("BOOL")] int* isSystemFont);

        /// <summary>Initializes a LOGFONT public partial structure based on the GDI-compatible properties of the specified font.</summary>
        /// <param name="font">Specifies a font face.</param>
        /// <param name="logFont">Structure that receives a GDI-compatible font description.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConvertFontFaceToLOGFONT(IDWriteGdiInterop1* This, IDWriteFontFace* font, LOGFONT* logFont);

        /// <summary>Creates a font face object that corresponds to the currently selected HFONT.</summary>
        /// <param name="hdc">Handle to a device context into which a font has been selected. It is assumed that the client has already performed font mapping and that the font selected into the DC is the actual font that would be used for rendering glyphs.</param>
        /// <param name="fontFace">Contains the newly created font face object, or NULL in case of failure.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFaceFromHdc(IDWriteGdiInterop1* This, [NativeTypeName("HDC")] IntPtr hdc, IDWriteFontFace** fontFace);

        /// <summary>Creates an object that encapsulates a bitmap and memory DC which can be used for rendering glyphs.</summary>
        /// <param name="hdc">Optional device context used to create a compatible memory DC.</param>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="renderTarget">Receives a pointer to the newly created render target.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapRenderTarget(IDWriteGdiInterop1* This, [Optional, NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget);

        /// <summary>Creates a font object that matches the properties specified by the LOGFONT public partial structure.</summary>
        /// <param name="logFont">Structure containing a GDI-compatible font description.</param>
        /// <param name="fontCollection">The font collection to search. If NULL, the local system font collection is used.</param>
        /// <param name="font">Receives a newly created font object if successful, or NULL in case of error.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> The only fields that matter include: lfFaceName, lfCharSet, lfWeight, lfItalic. Font size and rendering mode are a rendering time property, not a font property, and text decorations like underline are drawn separately from the text. If no font matches the given weight, slope, and character set, the best match within the given GDI family name will be returned. DWRITE_E_NOFONT is returned if there is no matching font name using either the GDI family name (e.g. Arial) or the full font name (e.g. Arial Bold Italic).</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFromLOGFONT1(IDWriteGdiInterop1* This, LOGFONT* logFont, [Optional] IDWriteFontCollection* fontCollection, IDWriteFont** font);

        /// <summary>Reads the font signature from the given font.</summary>
        /// <param name="font">Font to read font signature from.</param>
        /// <param name="fontSignature">Font signature from the OS/2 table, ulUnicodeRange and ulCodePageRange.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSignature(IDWriteGdiInterop1* This, IDWriteFont* font, FONTSIGNATURE* fontSignature);

        /// <summary>Reads the font signature from the given font.</summary>
        /// <param name="fontFace">Font to read font signature from.</param>
        /// <param name="fontSignature">Font signature from the OS/2 table, ulUnicodeRange and ulCodePageRange.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSignature1(IDWriteGdiInterop1* This, IDWriteFontFace* fontFace, FONTSIGNATURE* fontSignature);

        /// <summary>Get a list of matching fonts based on the LOGFONT values. Only fonts of that family name will be returned.</summary>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFontsByLOGFONT(IDWriteGdiInterop1* This, LOGFONT* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT(LOGFONT* logFont, IDWriteFont** font)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFromLOGFONT>(lpVtbl->CreateFontFromLOGFONT)(This, logFont, font);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT(IDWriteFont* font, LOGFONT* logFont, [NativeTypeName("BOOL")] int* isSystemFont)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConvertFontToLOGFONT>(lpVtbl->ConvertFontToLOGFONT)(This, font, logFont, isSystemFont);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT(IDWriteFontFace* font, LOGFONT* logFont)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ConvertFontFaceToLOGFONT>(lpVtbl->ConvertFontFaceToLOGFONT)(This, font, logFont);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc([NativeTypeName("HDC")] IntPtr hdc, IDWriteFontFace** fontFace)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceFromHdc>(lpVtbl->CreateFontFaceFromHdc)(This, hdc, fontFace);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget([Optional, NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapRenderTarget>(lpVtbl->CreateBitmapRenderTarget)(This, hdc, width, height, renderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT1(LOGFONT* logFont, [Optional] IDWriteFontCollection* fontCollection, IDWriteFont** font)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateFontFromLOGFONT1>(lpVtbl->CreateFontFromLOGFONT1)(This, logFont, fontCollection, font);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature(IDWriteFont* font, FONTSIGNATURE* fontSignature)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSignature>(lpVtbl->GetFontSignature)(This, font, fontSignature);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature1(IDWriteFontFace* fontFace, FONTSIGNATURE* fontSignature)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontSignature1>(lpVtbl->GetFontSignature1)(This, fontFace, fontSignature);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFontsByLOGFONT(LOGFONT* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
        {
            fixed (IDWriteGdiInterop1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMatchingFontsByLOGFONT>(lpVtbl->GetMatchingFontsByLOGFONT)(This, logFont, fontSet, filteredSet);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateFontFromLOGFONT;

            public IntPtr ConvertFontToLOGFONT;

            public IntPtr ConvertFontFaceToLOGFONT;

            public IntPtr CreateFontFaceFromHdc;

            public IntPtr CreateBitmapRenderTarget;

            public IntPtr CreateFontFromLOGFONT1;

            public IntPtr GetFontSignature;

            public IntPtr GetFontSignature1;

            public IntPtr GetMatchingFontsByLOGFONT;
        }
    }
}