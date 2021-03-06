// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0EB1088C-4DCD-46F0-878F-39DAE86A51B7")]
    public unsafe partial struct IVMRWindowlessControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, Guid*, void**, int>)(lpVtbl[0]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint>)(lpVtbl[1]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint>)(lpVtbl[2]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight, [NativeTypeName("LONG *")] int* lpARWidth, [NativeTypeName("LONG *")] int* lpARHeight)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, int*, int*, int*, int*, int>)(lpVtbl[3]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight, lpARWidth, lpARHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMinIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, int*, int*, int>)(lpVtbl[4]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, int*, int*, int>)(lpVtbl[5]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoPosition([NativeTypeName("const LPRECT")] RECT* lpSRCRect, [NativeTypeName("const LPRECT")] RECT* lpDSTRect)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, RECT*, RECT*, int>)(lpVtbl[6]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpSRCRect, lpDSTRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoPosition([NativeTypeName("LPRECT")] RECT* lpSRCRect, [NativeTypeName("LPRECT")] RECT* lpDSTRect)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, RECT*, RECT*, int>)(lpVtbl[7]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpSRCRect, lpDSTRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAspectRatioMode([NativeTypeName("DWORD *")] uint* lpAspectRatioMode)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint*, int>)(lpVtbl[8]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpAspectRatioMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAspectRatioMode([NativeTypeName("DWORD")] uint AspectRatioMode)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint, int>)(lpVtbl[9]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), AspectRatioMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoClippingWindow([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, IntPtr, int>)(lpVtbl[10]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), hwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int RepaintVideo([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HDC")] IntPtr hdc)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, IntPtr, IntPtr, int>)(lpVtbl[11]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), hwnd, hdc);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisplayModeChanged()
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, int>)(lpVtbl[12]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentImage([NativeTypeName("BYTE **")] byte** lpDib)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, byte**, int>)(lpVtbl[13]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpDib);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("COLORREF")] uint Clr)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint, int>)(lpVtbl[14]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), Clr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBorderColor([NativeTypeName("COLORREF *")] uint* lpClr)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint*, int>)(lpVtbl[15]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpClr);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("COLORREF")] uint Clr)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint, int>)(lpVtbl[16]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), Clr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("COLORREF *")] uint* lpClr)
        {
            return ((delegate* stdcall<IVMRWindowlessControl*, uint*, int>)(lpVtbl[17]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpClr);
        }
    }
}
