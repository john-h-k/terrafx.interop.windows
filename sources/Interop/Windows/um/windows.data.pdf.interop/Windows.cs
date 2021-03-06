// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.Data.Pdf", EntryPoint = "PdfCreateRenderer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PdfCreateRenderer([NativeTypeName("IDXGIDevice *")] IDXGIDevice* pDevice, [NativeTypeName("IPdfRendererNative **")] IPdfRendererNative** ppRenderer);

        [NativeTypeName("const D2D_RECT_F")]
        public static readonly D2D_RECT_F sc_PdfRenderParamsDefaultSrcRect = new D2D_RECT_F
        {
            left = 0.0f,
            top = 0.0f,
            right = 0.0f,
            bottom = 0.0f,
        };

        [NativeTypeName("const D2D_COLOR_F")]
        public static readonly DXGI_RGBA sc_PdfRenderParamsDefaultBkColor = new DXGI_RGBA
        {
            r = 1.0f,
            g = 1.0f,
            b = 1.0f,
            a = 1.0f,
        };
    }
}
