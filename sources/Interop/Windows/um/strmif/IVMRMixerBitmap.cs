// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E673275-0257-40AA-AF20-7C608D4A0428")]
    public unsafe partial struct IVMRMixerBitmap
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVMRMixerBitmap*, Guid*, void**, int>)(lpVtbl[0]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVMRMixerBitmap*, uint>)(lpVtbl[1]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVMRMixerBitmap*, uint>)(lpVtbl[2]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlphaBitmap([NativeTypeName("const VMRALPHABITMAP *")] VMRALPHABITMAP* pBmpParms)
        {
            return ((delegate* stdcall<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[3]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms)
        {
            return ((delegate* stdcall<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[4]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms)
        {
            return ((delegate* stdcall<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[5]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
        }
    }
}
