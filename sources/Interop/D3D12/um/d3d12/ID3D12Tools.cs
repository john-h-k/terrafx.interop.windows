// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
    public unsafe partial struct ID3D12Tools
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Tools* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Tools* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Tools* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EnableShaderInstrumentation(ID3D12Tools* This, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _ShaderInstrumentationEnabled(ID3D12Tools* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12Tools* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12Tools* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12Tools* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void EnableShaderInstrumentation([NativeTypeName("BOOL")] int bEnable)
        {
            fixed (ID3D12Tools* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EnableShaderInstrumentation>(lpVtbl->EnableShaderInstrumentation)(This, bEnable);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int ShaderInstrumentationEnabled()
        {
            fixed (ID3D12Tools* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ShaderInstrumentationEnabled>(lpVtbl->ShaderInstrumentationEnabled)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr EnableShaderInstrumentation;

            public IntPtr ShaderInstrumentationEnabled;
        }
    }
}