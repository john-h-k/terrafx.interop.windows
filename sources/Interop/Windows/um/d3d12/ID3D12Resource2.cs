// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BE36EC3B-EA85-4AEB-A45A-E9D76404A495")]
    public unsafe partial struct ID3D12Resource2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12Resource2*, uint>)(lpVtbl[1]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12Resource2*, uint>)(lpVtbl[2]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12Resource2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12Resource2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12Resource2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12Resource2*, ushort*, int>)(lpVtbl[6]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange, [NativeTypeName("void **")] void** ppData)
        {
            return ((delegate* stdcall<ID3D12Resource2*, uint, D3D12_RANGE*, void**, int>)(lpVtbl[8]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
        }

        public void Unmap([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange)
        {
            ((delegate* stdcall<ID3D12Resource2*, uint, D3D12_RANGE*, void>)(lpVtbl[9]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
        }

        public D3D12_RESOURCE_DESC GetDesc()
        {
            D3D12_RESOURCE_DESC result;
            return *((delegate* stdcall<ID3D12Resource2*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_DESC*>)(lpVtbl[10]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong GetGPUVirtualAddress()
        {
            return ((delegate* stdcall<ID3D12Resource2*, ulong>)(lpVtbl[11]))((ID3D12Resource2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteToSubresource([NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            return ((delegate* stdcall<ID3D12Resource2*, uint, D3D12_BOX*, void*, uint, uint, int>)(lpVtbl[12]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFromSubresource([NativeTypeName("void *")] void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            return ((delegate* stdcall<ID3D12Resource2*, void*, uint, uint, uint, D3D12_BOX*, int>)(lpVtbl[13]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeapProperties([NativeTypeName("D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, [NativeTypeName("D3D12_HEAP_FLAGS *")] D3D12_HEAP_FLAGS* pHeapFlags)
        {
            return ((delegate* stdcall<ID3D12Resource2*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS*, int>)(lpVtbl[14]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppProtectedSession)
        {
            return ((delegate* stdcall<ID3D12Resource2*, Guid*, void**, int>)(lpVtbl[15]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }

        public D3D12_RESOURCE_DESC1 GetDesc1()
        {
            D3D12_RESOURCE_DESC1 result;
            return *((delegate* stdcall<ID3D12Resource2*, D3D12_RESOURCE_DESC1*, D3D12_RESOURCE_DESC1*>)(lpVtbl[16]))((ID3D12Resource2*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
