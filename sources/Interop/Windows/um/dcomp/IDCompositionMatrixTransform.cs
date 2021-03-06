// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("16CDFF07-C503-419c-83F2-0965C7AF1FA6")]
    public unsafe partial struct IDCompositionMatrixTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform*, uint>)(lpVtbl[1]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform*, uint>)(lpVtbl[2]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrix([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[3]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, float value)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform*, int, int, float, int>)(lpVtbl[4]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform*, int, int, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, animation);
        }
    }
}
