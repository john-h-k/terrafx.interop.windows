// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
    public unsafe partial struct ID2D1SvgGlyphStyle
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SvgGlyphStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[1]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[2]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFill([NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            return ((delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)(lpVtbl[4]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        public void GetFill([NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush)
        {
            ((delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)(lpVtbl[5]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStroke([NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("const FLOAT *")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT")] float dashOffset = 1.0f)
        {
            return ((delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)(lpVtbl[6]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetStrokeDashesCount()
        {
            return ((delegate* stdcall<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[7]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetStroke([NativeTypeName("ID2D1Brush **")] ID2D1Brush** brush, [NativeTypeName("FLOAT *")] float* strokeWidth = null, [NativeTypeName("FLOAT *")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT *")] float* dashOffset = null)
        {
            ((delegate* stdcall<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)(lpVtbl[8]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
        }
    }
}
