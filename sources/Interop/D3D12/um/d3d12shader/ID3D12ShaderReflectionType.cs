// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
    public unsafe partial struct ID3D12ShaderReflectionType
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12ShaderReflectionType* This, D3D12_SHADER_TYPE_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionType* _GetMemberTypeByIndex(ID3D12ShaderReflectionType* This, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionType* _GetMemberTypeByName(ID3D12ShaderReflectionType* This, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("LPSTR")]
        public delegate sbyte* _GetMemberTypeName(ID3D12ShaderReflectionType* This, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEqual(ID3D12ShaderReflectionType* This, ID3D12ShaderReflectionType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionType* _GetSubType(ID3D12ShaderReflectionType* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionType* _GetBaseClass(ID3D12ShaderReflectionType* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate uint _GetNumInterfaces(ID3D12ShaderReflectionType* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionType* _GetInterfaceByIndex(ID3D12ShaderReflectionType* This, [NativeTypeName("UINT")] uint uIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsOfType(ID3D12ShaderReflectionType* This, ID3D12ShaderReflectionType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ImplementsInterface(ID3D12ShaderReflectionType* This, ID3D12ShaderReflectionType* pBase);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D12_SHADER_TYPE_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        public ID3D12ShaderReflectionType* GetMemberTypeByIndex([NativeTypeName("UINT")] uint Index)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeByIndex>(lpVtbl->GetMemberTypeByIndex)(This, Index);
            }
        }

        public ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeByName>(lpVtbl->GetMemberTypeByName)(This, Name);
            }
        }

        [return: NativeTypeName("LPSTR")]
        public sbyte* GetMemberTypeName([NativeTypeName("UINT")] uint Index)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMemberTypeName>(lpVtbl->GetMemberTypeName)(This, Index);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual(ID3D12ShaderReflectionType* pType)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsEqual>(lpVtbl->IsEqual)(This, pType);
            }
        }

        public ID3D12ShaderReflectionType* GetSubType()
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSubType>(lpVtbl->GetSubType)(This);
            }
        }

        public ID3D12ShaderReflectionType* GetBaseClass()
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBaseClass>(lpVtbl->GetBaseClass)(This);
            }
        }

        public uint GetNumInterfaces()
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumInterfaces>(lpVtbl->GetNumInterfaces)(This);
            }
        }

        public ID3D12ShaderReflectionType* GetInterfaceByIndex([NativeTypeName("UINT")] uint uIndex)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInterfaceByIndex>(lpVtbl->GetInterfaceByIndex)(This, uIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsOfType(ID3D12ShaderReflectionType* pType)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsOfType>(lpVtbl->IsOfType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ImplementsInterface(ID3D12ShaderReflectionType* pBase)
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ImplementsInterface>(lpVtbl->ImplementsInterface)(This, pBase);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr GetDesc;

            public IntPtr GetMemberTypeByIndex;

            public IntPtr GetMemberTypeByName;

            public IntPtr GetMemberTypeName;

            public IntPtr IsEqual;

            public IntPtr GetSubType;

            public IntPtr GetBaseClass;

            public IntPtr GetNumInterfaces;

            public IntPtr GetInterfaceByIndex;

            public IntPtr IsOfType;

            public IntPtr ImplementsInterface;
        }
    }
}