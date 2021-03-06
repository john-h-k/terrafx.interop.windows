// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAE8B344-23FC-4071-8CB5-D05D6F073848")]
    public unsafe partial struct ID2D1InkStyle
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1InkStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1InkStyle*, uint>)(lpVtbl[1]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1InkStyle*, uint>)(lpVtbl[2]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1InkStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetNibTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* stdcall<ID2D1InkStyle*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[4]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        public void GetNibTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* stdcall<ID2D1InkStyle*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetNibShape(D2D1_INK_NIB_SHAPE nibShape)
        {
            ((delegate* stdcall<ID2D1InkStyle*, D2D1_INK_NIB_SHAPE, void>)(lpVtbl[6]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this), nibShape);
        }

        public D2D1_INK_NIB_SHAPE GetNibShape()
        {
            return ((delegate* stdcall<ID2D1InkStyle*, D2D1_INK_NIB_SHAPE>)(lpVtbl[7]))((ID2D1InkStyle*)Unsafe.AsPointer(ref this));
        }
    }
}
