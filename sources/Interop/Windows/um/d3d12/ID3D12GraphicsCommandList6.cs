// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3827890-E548-4CFA-96CF-5689A9370F80")]
    public unsafe partial struct ID3D12GraphicsCommandList6
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint>)(lpVtbl[1]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint>)(lpVtbl[2]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, ushort*, int>)(lpVtbl[6]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public new D3D12_COMMAND_LIST_TYPE GetType()
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_COMMAND_LIST_TYPE>)(lpVtbl[8]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, int>)(lpVtbl[9]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("ID3D12CommandAllocator *")] ID3D12CommandAllocator* pAllocator, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pInitialState)
        {
            return ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)(lpVtbl[10]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pAllocator, pInitialState);
        }

        public void ClearState([NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12PipelineState*, void>)(lpVtbl[11]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pPipelineState);
        }

        public void DrawInstanced([NativeTypeName("UINT")] uint VertexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, uint, uint, void>)(lpVtbl[12]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        public void DrawIndexedInstanced([NativeTypeName("UINT")] uint IndexCountPerInstance, [NativeTypeName("UINT")] uint InstanceCount, [NativeTypeName("UINT")] uint StartIndexLocation, [NativeTypeName("INT")] int BaseVertexLocation, [NativeTypeName("UINT")] uint StartInstanceLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, uint, int, uint, void>)(lpVtbl[13]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        public void Dispatch([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, uint, void>)(lpVtbl[14]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        public void CopyBufferRegion([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)(lpVtbl[15]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }

        public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("UINT")] uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_TEXTURE_COPY_LOCATION*, uint, uint, uint, D3D12_TEXTURE_COPY_LOCATION*, D3D12_BOX*, void>)(lpVtbl[16]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
        }

        public void CopyResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, ID3D12Resource*, void>)(lpVtbl[17]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
        }

        public void CopyTiles([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, ID3D12Resource*, ulong, D3D12_TILE_COPY_FLAGS, void>)(lpVtbl[18]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        public void ResolveSubresource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, DXGI_FORMAT Format)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, uint, ID3D12Resource*, uint, DXGI_FORMAT, void>)(lpVtbl[19]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        public void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D_PRIMITIVE_TOPOLOGY, void>)(lpVtbl[20]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), PrimitiveTopology);
        }

        public void RSSetViewports([NativeTypeName("UINT")] uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_VIEWPORT*, void>)(lpVtbl[21]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        public void RSSetScissorRects([NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, RECT*, void>)(lpVtbl[22]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        public void OMSetBlendFactor([NativeTypeName("const FLOAT [4]")] float* BlendFactor)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, float*, void>)(lpVtbl[23]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), BlendFactor);
        }

        public void OMSetStencilRef([NativeTypeName("UINT")] uint StencilRef)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, void>)(lpVtbl[24]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), StencilRef);
        }

        public void SetPipelineState([NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipelineState)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12PipelineState*, void>)(lpVtbl[25]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pPipelineState);
        }

        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_RESOURCE_BARRIER*, void>)(lpVtbl[26]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        public void ExecuteBundle([NativeTypeName("ID3D12GraphicsCommandList *")] ID3D12GraphicsCommandList* pCommandList)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12GraphicsCommandList*, void>)(lpVtbl[27]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pCommandList);
        }

        public void SetDescriptorHeaps([NativeTypeName("UINT")] uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ID3D12DescriptorHeap**, void>)(lpVtbl[28]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, ppDescriptorHeaps);
        }

        public void SetComputeRootSignature([NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12RootSignature*, void>)(lpVtbl[29]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pRootSignature);
        }

        public void SetGraphicsRootSignature([NativeTypeName("ID3D12RootSignature *")] ID3D12RootSignature* pRootSignature)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12RootSignature*, void>)(lpVtbl[30]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pRootSignature);
        }

        public void SetComputeRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[31]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        public void SetGraphicsRootDescriptorTable([NativeTypeName("UINT")] uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void>)(lpVtbl[32]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        public void SetComputeRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, uint, void>)(lpVtbl[33]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        public void SetGraphicsRoot32BitConstant([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint SrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, uint, void>)(lpVtbl[34]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        public void SetComputeRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, void*, uint, void>)(lpVtbl[35]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        public void SetGraphicsRoot32BitConstants([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("UINT")] uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint DestOffsetIn32BitValues)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, void*, uint, void>)(lpVtbl[36]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        public void SetComputeRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ulong, void>)(lpVtbl[37]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootConstantBufferView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ulong, void>)(lpVtbl[38]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetComputeRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ulong, void>)(lpVtbl[39]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootShaderResourceView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ulong, void>)(lpVtbl[40]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetComputeRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ulong, void>)(lpVtbl[41]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void SetGraphicsRootUnorderedAccessView([NativeTypeName("UINT")] uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, ulong, void>)(lpVtbl[42]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_INDEX_BUFFER_VIEW*, void>)(lpVtbl[43]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pView);
        }

        public void IASetVertexBuffers([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, D3D12_VERTEX_BUFFER_VIEW*, void>)(lpVtbl[44]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        public void SOSetTargets([NativeTypeName("UINT")] uint StartSlot, [NativeTypeName("UINT")] uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, D3D12_STREAM_OUTPUT_BUFFER_VIEW*, void>)(lpVtbl[45]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        public void OMSetRenderTargets([NativeTypeName("UINT")] uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, [NativeTypeName("BOOL")] int RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, int, D3D12_CPU_DESCRIPTOR_HANDLE*, void>)(lpVtbl[46]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }

        public void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, [NativeTypeName("FLOAT")] float Depth, [NativeTypeName("UINT8")] byte Stencil, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, float, byte, uint, RECT*, void>)(lpVtbl[47]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
        }

        public void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("const FLOAT [4]")] float* ColorRGBA, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_CPU_DESCRIPTOR_HANDLE, float*, uint, RECT*, void>)(lpVtbl[48]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
        }

        public void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const UINT [4]")] uint* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, uint*, uint, RECT*, void>)(lpVtbl[49]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        public void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const FLOAT [4]")] float* Values, [NativeTypeName("UINT")] uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, float*, uint, RECT*, void>)(lpVtbl[50]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        public void DiscardResource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, D3D12_DISCARD_REGION*, void>)(lpVtbl[51]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pResource, pRegion);
        }

        public void BeginQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[52]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void EndQuery([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[53]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        public void ResolveQueryData([NativeTypeName("ID3D12QueryHeap *")] ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void>)(lpVtbl[54]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        public void SetPredication([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void>)(lpVtbl[55]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
        }

        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, void*, uint, void>)(lpVtbl[56]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, void*, uint, void>)(lpVtbl[57]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        public void EndEvent()
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, void>)(lpVtbl[58]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        public void ExecuteIndirect([NativeTypeName("ID3D12CommandSignature *")] ID3D12CommandSignature* pCommandSignature, [NativeTypeName("UINT")] uint MaxCommandCount, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)(lpVtbl[59]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }

        public void AtomicCopyBufferUINT([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, D3D12_SUBRESOURCE_RANGE_UINT64*, void>)(lpVtbl[60]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        public void AtomicCopyBufferUINT64([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT")] uint Dependencies, [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource** ppDependentResources, [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")] D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, D3D12_SUBRESOURCE_RANGE_UINT64*, void>)(lpVtbl[61]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        public void OMSetDepthBounds([NativeTypeName("FLOAT")] float Min, [NativeTypeName("FLOAT")] float Max)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, float, float, void>)(lpVtbl[62]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Min, Max);
        }

        public void SetSamplePositions([NativeTypeName("UINT")] uint NumSamplesPerPixel, [NativeTypeName("UINT")] uint NumPixels, [NativeTypeName("D3D12_SAMPLE_POSITION *")] D3D12_SAMPLE_POSITION* pSamplePositions)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, D3D12_SAMPLE_POSITION*, void>)(lpVtbl[63]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumSamplesPerPixel, NumPixels, pSamplePositions);
        }

        public void ResolveSubresourceRegion([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDstResource, [NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("UINT")] uint DstX, [NativeTypeName("UINT")] uint DstY, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSrcResource, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("D3D12_RECT *")] RECT* pSrcRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, RECT*, DXGI_FORMAT, D3D12_RESOLVE_MODE, void>)(lpVtbl[64]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        public void SetViewInstanceMask([NativeTypeName("UINT")] uint Mask)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, void>)(lpVtbl[65]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Mask);
        }

        public void WriteBufferImmediate([NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void>)(lpVtbl[66]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        public void SetProtectedResourceSession([NativeTypeName("ID3D12ProtectedResourceSession *")] ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12ProtectedResourceSession*, void>)(lpVtbl[67]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
        }

        public void BeginRenderPass([NativeTypeName("UINT")] uint NumRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC *")] D3D12_RENDER_PASS_RENDER_TARGET_DESC* pRenderTargets, [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *")] D3D12_RENDER_PASS_DEPTH_STENCIL_DESC* pDepthStencil, D3D12_RENDER_PASS_FLAGS Flags)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, D3D12_RENDER_PASS_RENDER_TARGET_DESC*, D3D12_RENDER_PASS_DEPTH_STENCIL_DESC*, D3D12_RENDER_PASS_FLAGS, void>)(lpVtbl[68]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), NumRenderTargets, pRenderTargets, pDepthStencil, Flags);
        }

        public void EndRenderPass()
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, void>)(lpVtbl[69]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this));
        }

        public void InitializeMetaCommand([NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pInitializationParametersData, [NativeTypeName("SIZE_T")] nuint InitializationParametersDataSizeInBytes)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12MetaCommand*, void*, nuint, void>)(lpVtbl[70]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pMetaCommand, pInitializationParametersData, InitializationParametersDataSizeInBytes);
        }

        public void ExecuteMetaCommand([NativeTypeName("ID3D12MetaCommand *")] ID3D12MetaCommand* pMetaCommand, [NativeTypeName("const void *")] void* pExecutionParametersData, [NativeTypeName("SIZE_T")] nuint ExecutionParametersDataSizeInBytes)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12MetaCommand*, void*, nuint, void>)(lpVtbl[71]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pMetaCommand, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
        }

        public void BuildRaytracingAccelerationStructure([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC* pDesc, [NativeTypeName("UINT")] uint NumPostbuildInfoDescs, [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pPostbuildInfoDescs)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC*, uint, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*, void>)(lpVtbl[72]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescs);
        }

        public void EmitRaytracingAccelerationStructurePostbuildInfo([NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")] D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pDesc, [NativeTypeName("UINT")] uint NumSourceAccelerationStructures, [NativeTypeName("const D3D12_GPU_VIRTUAL_ADDRESS *")] ulong* pSourceAccelerationStructureData)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*, uint, ulong*, void>)(lpVtbl[73]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
        }

        public void CopyRaytracingAccelerationStructure([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong DestAccelerationStructureData, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong SourceAccelerationStructureData, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ulong, ulong, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE, void>)(lpVtbl[74]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), DestAccelerationStructureData, SourceAccelerationStructureData, Mode);
        }

        public void SetPipelineState1([NativeTypeName("ID3D12StateObject *")] ID3D12StateObject* pStateObject)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12StateObject*, void>)(lpVtbl[75]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pStateObject);
        }

        public void DispatchRays([NativeTypeName("const D3D12_DISPATCH_RAYS_DESC *")] D3D12_DISPATCH_RAYS_DESC* pDesc)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_DISPATCH_RAYS_DESC*, void>)(lpVtbl[76]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), pDesc);
        }

        public void RSSetShadingRate(D3D12_SHADING_RATE baseShadingRate, [NativeTypeName("const D3D12_SHADING_RATE_COMBINER *")] D3D12_SHADING_RATE_COMBINER* combiners)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, D3D12_SHADING_RATE, D3D12_SHADING_RATE_COMBINER*, void>)(lpVtbl[77]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), baseShadingRate, combiners);
        }

        public void RSSetShadingRateImage([NativeTypeName("ID3D12Resource *")] ID3D12Resource* shadingRateImage)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, ID3D12Resource*, void>)(lpVtbl[78]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), shadingRateImage);
        }

        public void DispatchMesh([NativeTypeName("UINT")] uint ThreadGroupCountX, [NativeTypeName("UINT")] uint ThreadGroupCountY, [NativeTypeName("UINT")] uint ThreadGroupCountZ)
        {
            ((delegate* stdcall<ID3D12GraphicsCommandList6*, uint, uint, uint, void>)(lpVtbl[79]))((ID3D12GraphicsCommandList6*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }
    }
}
