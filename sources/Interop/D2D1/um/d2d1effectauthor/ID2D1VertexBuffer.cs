// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to write new vertices to a vertex buffer.</summary>
    [Guid("9B8B1336-00A5-4668-92B7-CED5D8BF9B7B")]
    public unsafe partial struct ID2D1VertexBuffer
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1VertexBuffer* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1VertexBuffer* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1VertexBuffer* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(ID2D1VertexBuffer* This, [NativeTypeName("BYTE[]")] byte** data, [NativeTypeName("UINT32")] uint bufferSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unmap(ID2D1VertexBuffer* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1VertexBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1VertexBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1VertexBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("BYTE[]")] byte** data, [NativeTypeName("UINT32")] uint bufferSize)
        {
            fixed (ID2D1VertexBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)(This, data, bufferSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            fixed (ID2D1VertexBuffer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Map;

            public IntPtr Unmap;
        }
    }
}