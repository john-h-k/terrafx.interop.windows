// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6C14DB81-A733-11CE-A521-0020AF0BE560")]
    public unsafe partial struct IDirectDrawSurface
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint>)(lpVtbl[1]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint>)(lpVtbl[2]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDrawSurface*, int>)(lpVtbl[3]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, RECT*, IDirectDrawSurface*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, uint, IDirectDrawSurface*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, IDirectDrawSurface*, int>)(lpVtbl[8]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int> param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, void*, delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int>, int>)(lpVtbl[9]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int> param2)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, void*, delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, void*, int>, int>)(lpVtbl[10]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flip([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDrawSurface*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttachedSurface([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, DDSCAPS*, IDirectDrawSurface**, int>)(lpVtbl[12]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBltStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, DDSCAPS*, int>)(lpVtbl[14]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("HDC *")] IntPtr* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IntPtr*, int>)(lpVtbl[17]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlipStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, DDSURFACEDESC*, int>)(lpVtbl[22]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[23]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsLost()
        {
            return ((delegate* stdcall<IDirectDrawSurface*, int>)(lpVtbl[24]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] IntPtr param3)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, RECT*, DDSURFACEDESC*, uint, IntPtr, int>)(lpVtbl[25]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IntPtr, int>)(lpVtbl[26]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Restore()
        {
            return ((delegate* stdcall<IDirectDrawSurface*, int>)(lpVtbl[27]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unlock([NativeTypeName("LPVOID")] void* param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, void*, int>)(lpVtbl[32]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, RECT*, IDirectDrawSurface*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param1)
        {
            return ((delegate* stdcall<IDirectDrawSurface*, uint, IDirectDrawSurface*, int>)(lpVtbl[35]))((IDirectDrawSurface*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
