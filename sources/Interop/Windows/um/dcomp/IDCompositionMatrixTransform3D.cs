// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B3363F0-643B-41b7-B6E0-CCF22D34467C")]
    public unsafe partial struct IDCompositionMatrixTransform3D
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform3D*, uint>)(lpVtbl[1]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform3D*, uint>)(lpVtbl[2]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrix([NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform3D*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[3]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), matrix);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, float value)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform3D*, int, int, float, int>)(lpVtbl[4]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMatrixElement(int row, int column, [NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionMatrixTransform3D*, int, int, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, animation);
        }
    }
}
