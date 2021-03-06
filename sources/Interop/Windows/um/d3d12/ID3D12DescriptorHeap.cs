// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8EFB471D-616C-4F49-90F7-127BB763FA51")]
    public unsafe partial struct ID3D12DescriptorHeap
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, uint>)(lpVtbl[1]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, uint>)(lpVtbl[2]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, ushort*, int>)(lpVtbl[6]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D12DescriptorHeap*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public D3D12_DESCRIPTOR_HEAP_DESC GetDesc()
        {
            D3D12_DESCRIPTOR_HEAP_DESC result;
            return *((delegate* stdcall<ID3D12DescriptorHeap*, D3D12_DESCRIPTOR_HEAP_DESC*, D3D12_DESCRIPTOR_HEAP_DESC*>)(lpVtbl[8]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), &result);
        }

        public D3D12_CPU_DESCRIPTOR_HANDLE GetCPUDescriptorHandleForHeapStart()
        {
            D3D12_CPU_DESCRIPTOR_HANDLE result;
            return *((delegate* stdcall<ID3D12DescriptorHeap*, D3D12_CPU_DESCRIPTOR_HANDLE*, D3D12_CPU_DESCRIPTOR_HANDLE*>)(lpVtbl[9]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), &result);
        }

        public D3D12_GPU_DESCRIPTOR_HANDLE GetGPUDescriptorHandleForHeapStart()
        {
            D3D12_GPU_DESCRIPTOR_HANDLE result;
            return *((delegate* stdcall<ID3D12DescriptorHeap*, D3D12_GPU_DESCRIPTOR_HANDLE*, D3D12_GPU_DESCRIPTOR_HANDLE*>)(lpVtbl[10]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
