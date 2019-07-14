// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("A9B71770-D099-4A65-A698-3DEE10020F88")]
    public unsafe struct ID3D12DebugDevice1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12DebugDevice1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12DebugDevice1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12DebugDevice1* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetDebugParameter(
            [In] ID3D12DebugDevice1* This,
            [In] D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
            [In] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDebugParameter(
            [In] ID3D12DebugDevice1* This,
            [In] D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
            [Out] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReportLiveDeviceObjects(
            [In] ID3D12DebugDevice1* This,
            [In] D3D12_RLDO_FLAGS Flags
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(
            [In] D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
            [In] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        )
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return MarshalFunction<_SetDebugParameter>(lpVtbl->SetDebugParameter)(
                    This,
                    Type,
                    pData,
                    DataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(
            [In] D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
            [Out] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        )
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return MarshalFunction<_GetDebugParameter>(lpVtbl->GetDebugParameter)(
                    This,
                    Type,
                    pData,
                    DataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(
            [In] D3D12_RLDO_FLAGS Flags
        )
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return MarshalFunction<_ReportLiveDeviceObjects>(lpVtbl->ReportLiveDeviceObjects)(
                    This,
                    Flags
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr SetDebugParameter;

            public IntPtr GetDebugParameter;

            public IntPtr ReportLiveDeviceObjects;
            #endregion
        }
        #endregion
    }
}