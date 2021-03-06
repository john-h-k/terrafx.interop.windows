// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A5B6FD1-CD73-4B6C-9CF4-2E869EAF470A")]
    public unsafe partial struct ICoreWindowAdapterInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, uint>)(lpVtbl[1]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, uint>)(lpVtbl[2]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ApplicationViewClientAdapter([NativeTypeName("IUnknown **")] IUnknown** value)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[6]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CoreApplicationViewClientAdapter([NativeTypeName("IUnknown **")] IUnknown** value)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[7]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_HoloViewClientAdapter([NativeTypeName("IUnknown **")] IUnknown** value)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[8]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_SystemNavigationClientAdapter([NativeTypeName("IUnknown **")] IUnknown** value)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[9]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_TitleBarClientAdapter([NativeTypeName("IUnknown **")] IUnknown** value)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IUnknown**, int>)(lpVtbl[10]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWindowClientAdapter([NativeTypeName("IUnknown *")] IUnknown* value)
        {
            return ((delegate* stdcall<ICoreWindowAdapterInterop*, IUnknown*, int>)(lpVtbl[11]))((ICoreWindowAdapterInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
