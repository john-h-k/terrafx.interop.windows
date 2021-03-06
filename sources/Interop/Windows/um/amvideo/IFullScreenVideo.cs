// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IFullScreenVideo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IFullScreenVideo*, Guid*, void**, int>)(lpVtbl[0]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IFullScreenVideo*, uint>)(lpVtbl[1]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IFullScreenVideo*, uint>)(lpVtbl[2]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CountModes([NativeTypeName("long *")] int* pModes)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int*, int>)(lpVtbl[3]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pModes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int*, int*, int*, int>)(lpVtbl[4]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMode([NativeTypeName("long *")] int* pMode)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int*, int>)(lpVtbl[5]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsModeAvailable([NativeTypeName("long")] int Mode)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int>)(lpVtbl[6]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsModeEnabled([NativeTypeName("long")] int Mode)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int>)(lpVtbl[7]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int, int>)(lpVtbl[8]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode, bEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int*, int>)(lpVtbl[9]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pClipFactor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClipFactor([NativeTypeName("long")] int ClipFactor)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int>)(lpVtbl[10]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), ClipFactor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageDrain([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* stdcall<IFullScreenVideo*, IntPtr, int>)(lpVtbl[11]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), hwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessageDrain([NativeTypeName("HWND *")] IntPtr* hwnd)
        {
            return ((delegate* stdcall<IFullScreenVideo*, IntPtr*, int>)(lpVtbl[12]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), hwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMonitor([NativeTypeName("long")] int Monitor)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int>)(lpVtbl[13]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Monitor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMonitor([NativeTypeName("long *")] int* Monitor)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int*, int>)(lpVtbl[14]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Monitor);
        }

        [return: NativeTypeName("HRESULT")]
        public int HideOnDeactivate([NativeTypeName("long")] int Hide)
        {
            return ((delegate* stdcall<IFullScreenVideo*, int, int>)(lpVtbl[15]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Hide);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsHideOnDeactivate()
        {
            return ((delegate* stdcall<IFullScreenVideo*, int>)(lpVtbl[16]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* stdcall<IFullScreenVideo*, ushort*, int>)(lpVtbl[17]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), strCaption);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
        {
            return ((delegate* stdcall<IFullScreenVideo*, ushort**, int>)(lpVtbl[18]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pstrCaption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefault()
        {
            return ((delegate* stdcall<IFullScreenVideo*, int>)(lpVtbl[19]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }
    }
}
