// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IFullScreenVideoEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, Guid*, void**, int>)(lpVtbl[0]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, uint>)(lpVtbl[1]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, uint>)(lpVtbl[2]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CountModes([NativeTypeName("long *")] int* pModes)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int*, int>)(lpVtbl[3]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pModes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int*, int*, int*, int>)(lpVtbl[4]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMode([NativeTypeName("long *")] int* pMode)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int*, int>)(lpVtbl[5]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsModeAvailable([NativeTypeName("long")] int Mode)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int>)(lpVtbl[6]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsModeEnabled([NativeTypeName("long")] int Mode)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int>)(lpVtbl[7]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int, int>)(lpVtbl[8]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, bEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int*, int>)(lpVtbl[9]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pClipFactor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClipFactor([NativeTypeName("long")] int ClipFactor)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int>)(lpVtbl[10]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), ClipFactor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageDrain([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, IntPtr, int>)(lpVtbl[11]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessageDrain([NativeTypeName("HWND *")] IntPtr* hwnd)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, IntPtr*, int>)(lpVtbl[12]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMonitor([NativeTypeName("long")] int Monitor)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int>)(lpVtbl[13]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMonitor([NativeTypeName("long *")] int* Monitor)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int*, int>)(lpVtbl[14]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
        }

        [return: NativeTypeName("HRESULT")]
        public int HideOnDeactivate([NativeTypeName("long")] int Hide)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int>)(lpVtbl[15]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Hide);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsHideOnDeactivate()
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int>)(lpVtbl[16]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, ushort*, int>)(lpVtbl[17]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), strCaption);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, ushort**, int>)(lpVtbl[18]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pstrCaption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefault()
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int>)(lpVtbl[19]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAcceleratorTable([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HACCEL")] IntPtr hAccel)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, IntPtr, IntPtr, int>)(lpVtbl[20]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd, hAccel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcceleratorTable([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("HACCEL *")] IntPtr* phAccel)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, IntPtr*, IntPtr*, int>)(lpVtbl[21]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), phwnd, phAccel);
        }

        [return: NativeTypeName("HRESULT")]
        public int KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int, int>)(lpVtbl[22]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), KeepAspect);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect)
        {
            return ((delegate* stdcall<IFullScreenVideoEx*, int*, int>)(lpVtbl[23]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pKeepAspect);
        }
    }
}
