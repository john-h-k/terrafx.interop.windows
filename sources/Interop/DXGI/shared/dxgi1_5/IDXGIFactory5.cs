// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7632E1F5-EE65-4DCA-87FD-84CD75F8838D")]
    public unsafe partial struct IDXGIFactory5
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIFactory5* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIFactory5* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIFactory5* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIFactory5* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIFactory5* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIFactory5* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIFactory5* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters(IDXGIFactory5* This, [NativeTypeName("UINT")] uint Adapter, IDXGIAdapter** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeWindowAssociation(IDXGIFactory5* This, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowAssociation(IDXGIFactory5* This, [NativeTypeName("HWND")] IntPtr* pWindowHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChain(IDXGIFactory5* This, IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSoftwareAdapter(IDXGIFactory5* This, [NativeTypeName("HMODULE")] IntPtr Module, IDXGIAdapter** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters1(IDXGIFactory5* This, [NativeTypeName("UINT")] uint Adapter, IDXGIAdapter1** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsCurrent(IDXGIFactory5* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsWindowedStereoEnabled(IDXGIFactory5* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForHwnd(IDXGIFactory5* This, IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForCoreWindow(IDXGIFactory5* This, IUnknown* pDevice, IUnknown* pWindow, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharedResourceAdapterLuid(IDXGIFactory5* This, [NativeTypeName("HANDLE")] IntPtr hResource, LUID* pLuid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusWindow(IDXGIFactory5* This, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusEvent(IDXGIFactory5* This, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterStereoStatus(IDXGIFactory5* This, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusWindow(IDXGIFactory5* This, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusEvent(IDXGIFactory5* This, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterOcclusionStatus(IDXGIFactory5* This, [NativeTypeName("UINT")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForComposition(IDXGIFactory5* This, IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetCreationFlags(IDXGIFactory5* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapterByLuid(IDXGIFactory5* This, LUID AdapterLuid, [NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumWarpAdapter(IDXGIFactory5* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(IDXGIFactory5* This, DXGI_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, IDXGIAdapter** ppAdapter)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapters>(lpVtbl->EnumAdapters)(This, Adapter, ppAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MakeWindowAssociation>(lpVtbl->MakeWindowAssociation)(This, WindowHandle, Flags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND")] IntPtr* pWindowHandle)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWindowAssociation>(lpVtbl->GetWindowAssociation)(This, pWindowHandle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChain>(lpVtbl->CreateSwapChain)(This, pDevice, pDesc, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, IDXGIAdapter** ppAdapter)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSoftwareAdapter>(lpVtbl->CreateSoftwareAdapter)(This, Module, ppAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1([NativeTypeName("UINT")] uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapters1>(lpVtbl->EnumAdapters1)(This, Adapter, ppAdapter);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsCurrent>(lpVtbl->IsCurrent)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsWindowedStereoEnabled()
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsWindowedStereoEnabled>(lpVtbl->IsWindowedStereoEnabled)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForHwnd(IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForHwnd>(lpVtbl->CreateSwapChainForHwnd)(This, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForCoreWindow>(lpVtbl->CreateSwapChainForCoreWindow)(This, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] IntPtr hResource, LUID* pLuid)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSharedResourceAdapterLuid>(lpVtbl->GetSharedResourceAdapterLuid)(This, hResource, pLuid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusWindow>(lpVtbl->RegisterStereoStatusWindow)(This, WindowHandle, wMsg, pdwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusEvent>(lpVtbl->RegisterStereoStatusEvent)(This, hEvent, pdwCookie);
            }
        }

        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterStereoStatus>(lpVtbl->UnregisterStereoStatus)(This, dwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusWindow>(lpVtbl->RegisterOcclusionStatusWindow)(This, WindowHandle, wMsg, pdwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusEvent>(lpVtbl->RegisterOcclusionStatusEvent)(This, hEvent, pdwCookie);
            }
        }

        public void UnregisterOcclusionStatus([NativeTypeName("UINT")] uint dwCookie)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterOcclusionStatus>(lpVtbl->UnregisterOcclusionStatus)(This, dwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForComposition(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForComposition>(lpVtbl->CreateSwapChainForComposition)(This, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCreationFlags>(lpVtbl->GetCreationFlags)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapterByLuid>(lpVtbl->EnumAdapterByLuid)(This, AdapterLuid, riid, ppvAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumWarpAdapter([NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumWarpAdapter>(lpVtbl->EnumWarpAdapter)(This, riid, ppvAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DXGI_FEATURE Feature, void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            fixed (IDXGIFactory5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)(This, Feature, pFeatureSupportData, FeatureSupportDataSize);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr EnumAdapters;

            public IntPtr MakeWindowAssociation;

            public IntPtr GetWindowAssociation;

            public IntPtr CreateSwapChain;

            public IntPtr CreateSoftwareAdapter;

            public IntPtr EnumAdapters1;

            public IntPtr IsCurrent;

            public IntPtr IsWindowedStereoEnabled;

            public IntPtr CreateSwapChainForHwnd;

            public IntPtr CreateSwapChainForCoreWindow;

            public IntPtr GetSharedResourceAdapterLuid;

            public IntPtr RegisterStereoStatusWindow;

            public IntPtr RegisterStereoStatusEvent;

            public IntPtr UnregisterStereoStatus;

            public IntPtr RegisterOcclusionStatusWindow;

            public IntPtr RegisterOcclusionStatusEvent;

            public IntPtr UnregisterOcclusionStatus;

            public IntPtr CreateSwapChainForComposition;

            public IntPtr GetCreationFlags;

            public IntPtr EnumAdapterByLuid;

            public IntPtr EnumWarpAdapter;

            public IntPtr CheckFeatureSupport;
        }
    }
}