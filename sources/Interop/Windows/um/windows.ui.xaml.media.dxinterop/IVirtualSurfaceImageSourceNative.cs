// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9550983-360B-4F53-B391-AFD695078691")]
    public unsafe partial struct IVirtualSurfaceImageSourceNative
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, uint>)(lpVtbl[1]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, uint>)(lpVtbl[2]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* device)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, IDXGIDevice*, int>)(lpVtbl[3]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), device);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw(RECT updateRect, [NativeTypeName("IDXGISurface **")] IDXGISurface** surface, [NativeTypeName("POINT *")] POINT* offset)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, RECT, IDXGISurface**, POINT*, int>)(lpVtbl[4]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect, surface, offset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, int>)(lpVtbl[5]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Invalidate(RECT updateRect)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, RECT, int>)(lpVtbl[6]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUpdateRectCount([NativeTypeName("DWORD *")] uint* count)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, uint*, int>)(lpVtbl[7]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), count);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUpdateRects([NativeTypeName("RECT *")] RECT* updates, [NativeTypeName("DWORD")] uint count)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, RECT*, uint, int>)(lpVtbl[8]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updates, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVisibleBounds([NativeTypeName("RECT *")] RECT* bounds)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, RECT*, int>)(lpVtbl[9]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), bounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterForUpdatesNeeded([NativeTypeName("IVirtualSurfaceUpdatesCallbackNative *")] IVirtualSurfaceUpdatesCallbackNative* callback)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, IVirtualSurfaceUpdatesCallbackNative*, int>)(lpVtbl[10]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), callback);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("INT")] int newWidth, [NativeTypeName("INT")] int newHeight)
        {
            return ((delegate* stdcall<IVirtualSurfaceImageSourceNative*, int, int, int>)(lpVtbl[11]))((IVirtualSurfaceImageSourceNative*)Unsafe.AsPointer(ref this), newWidth, newHeight);
        }
    }
}
