// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3DDestructionNotifier* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3DDestructionNotifier* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3DDestructionNotifier* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterDestructionCallback(ID3DDestructionNotifier* This, [NativeTypeName("PFN_DESTRUCTION_CALLBACK")] IntPtr callbackFn, void* pData, [NativeTypeName("UINT")] uint* pCallbackID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnregisterDestructionCallback(ID3DDestructionNotifier* This, [NativeTypeName("UINT")] uint callbackID);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] IntPtr callbackFn, void* pData, [NativeTypeName("UINT")] uint* pCallbackID)
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterDestructionCallback>(lpVtbl->RegisterDestructionCallback)(This, callbackFn, pData, pCallbackID);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback([NativeTypeName("UINT")] uint callbackID)
        {
            fixed (ID3DDestructionNotifier* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnregisterDestructionCallback>(lpVtbl->UnregisterDestructionCallback)(This, callbackID);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr RegisterDestructionCallback;

            public IntPtr UnregisterDestructionCallback;
        }
    }
}