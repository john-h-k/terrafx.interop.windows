// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9D8E1289-D7B3-465F-8126-250E349AF85D")]
    public unsafe partial struct IDXGIKeyedMutex
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, uint>)(lpVtbl[1]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, uint>)(lpVtbl[2]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppDevice)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireSync([NativeTypeName("UINT64")] ulong Key, [NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, ulong, uint, int>)(lpVtbl[8]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Key, dwMilliseconds);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseSync([NativeTypeName("UINT64")] ulong Key)
        {
            return ((delegate* stdcall<IDXGIKeyedMutex*, ulong, int>)(lpVtbl[9]))((IDXGIKeyedMutex*)Unsafe.AsPointer(ref this), Key);
        }
    }
}
