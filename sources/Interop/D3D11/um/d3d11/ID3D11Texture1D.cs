// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F8FB5C27-C6B3-4F75-A4C8-439AF2EF564C")]
    public unsafe partial struct ID3D11Texture1D
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11Texture1D* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11Texture1D* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11Texture1D* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDevice(ID3D11Texture1D* pThis, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D11Texture1D* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D11Texture1D* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D11Texture1D* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetType(ID3D11Texture1D* pThis, [NativeTypeName("D3D11_RESOURCE_DIMENSION *")] D3D11_RESOURCE_DIMENSION* pResourceDimension);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetEvictionPriority(ID3D11Texture1D* pThis, [NativeTypeName("UINT")] uint EvictionPriority);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetEvictionPriority(ID3D11Texture1D* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesc(ID3D11Texture1D* pThis, [NativeTypeName("D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11Texture1D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11Texture1D*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetType([NativeTypeName("D3D11_RESOURCE_DIMENSION *")] D3D11_RESOURCE_DIMENSION* pResourceDimension)
        {
            Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), pResourceDimension);
        }

        public void SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            Marshal.GetDelegateForFunctionPointer<_SetEvictionPriority>(lpVtbl->SetEvictionPriority)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [return: NativeTypeName("UINT")]
        public uint GetEvictionPriority()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEvictionPriority>(lpVtbl->GetEvictionPriority)((ID3D11Texture1D*)Unsafe.AsPointer(ref this));
        }

        public void GetDesc([NativeTypeName("D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11Texture1D*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **)")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG ()")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG ()")]
            public IntPtr Release;

            [NativeTypeName("void (ID3D11Device **)")]
            public IntPtr GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *)")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *)")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *)")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("void (D3D11_RESOURCE_DIMENSION *)")]
            public new IntPtr GetType;

            [NativeTypeName("void (UINT)")]
            public IntPtr SetEvictionPriority;

            [NativeTypeName("UINT ()")]
            public IntPtr GetEvictionPriority;

            [NativeTypeName("void (D3D11_TEXTURE1D_DESC *)")]
            public IntPtr GetDesc;
        }
    }
}