// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E")]
    public unsafe partial struct ID3D12ShaderReflection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12ShaderReflection* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12ShaderReflection* This, D3D12_SHADER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByIndex(ID3D12ShaderReflection* This, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionConstantBuffer* _GetConstantBufferByName(ID3D12ShaderReflection* This, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDesc(ID3D12ShaderReflection* This, [NativeTypeName("UINT")] uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInputParameterDesc(ID3D12ShaderReflection* This, [NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOutputParameterDesc(ID3D12ShaderReflection* This, [NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPatchConstantParameterDesc(ID3D12ShaderReflection* This, [NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ID3D12ShaderReflectionVariable* _GetVariableByName(ID3D12ShaderReflection* This, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDescByName(ID3D12ShaderReflection* This, [NativeTypeName("LPCSTR")] sbyte* Name, D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetMovInstructionCount(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetMovcInstructionCount(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetConversionInstructionCount(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetBitwiseInstructionCount(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D_PRIMITIVE _GetGSInputPrimitive(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSampleFrequencyShader(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNumInterfaceSlots(ID3D12ShaderReflection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMinFeatureLevel(ID3D12ShaderReflection* This, D3D_FEATURE_LEVEL* pLevel);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetThreadGroupSize(ID3D12ShaderReflection* This, [NativeTypeName("UINT")] uint* pSizeX = null, [NativeTypeName("UINT")] uint* pSizeY = null, [NativeTypeName("UINT")] uint* pSizeZ = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetRequiresFlags(ID3D12ShaderReflection* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D12_SHADER_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, pDesc);
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByIndex>(lpVtbl->GetConstantBufferByIndex)(This, Index);
            }
        }

        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByName>(lpVtbl->GetConstantBufferByName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDesc>(lpVtbl->GetResourceBindingDesc)(This, ResourceIndex, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInputParameterDesc>(lpVtbl->GetInputParameterDesc)(This, ParameterIndex, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOutputParameterDesc>(lpVtbl->GetOutputParameterDesc)(This, ParameterIndex, pDesc);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPatchConstantParameterDesc>(lpVtbl->GetPatchConstantParameterDesc)(This, ParameterIndex, pDesc);
            }
        }

        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDescByName>(lpVtbl->GetResourceBindingDescByName)(This, Name, pDesc);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovInstructionCount()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMovInstructionCount>(lpVtbl->GetMovInstructionCount)(This);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovcInstructionCount()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMovcInstructionCount>(lpVtbl->GetMovcInstructionCount)(This);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetConversionInstructionCount()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetConversionInstructionCount>(lpVtbl->GetConversionInstructionCount)(This);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetBitwiseInstructionCount()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBitwiseInstructionCount>(lpVtbl->GetBitwiseInstructionCount)(This);
            }
        }

        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGSInputPrimitive>(lpVtbl->GetGSInputPrimitive)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSampleFrequencyShader()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsSampleFrequencyShader>(lpVtbl->IsSampleFrequencyShader)(This);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaceSlots()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumInterfaceSlots>(lpVtbl->GetNumInterfaceSlots)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel(D3D_FEATURE_LEVEL* pLevel)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMinFeatureLevel>(lpVtbl->GetMinFeatureLevel)(This, pLevel);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetThreadGroupSize([NativeTypeName("UINT")] uint* pSizeX = null, [NativeTypeName("UINT")] uint* pSizeY = null, [NativeTypeName("UINT")] uint* pSizeZ = null)
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetThreadGroupSize>(lpVtbl->GetThreadGroupSize)(This, pSizeX, pSizeY, pSizeZ);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            fixed (ID3D12ShaderReflection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRequiresFlags>(lpVtbl->GetRequiresFlags)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetDesc;

            public IntPtr GetConstantBufferByIndex;

            public IntPtr GetConstantBufferByName;

            public IntPtr GetResourceBindingDesc;

            public IntPtr GetInputParameterDesc;

            public IntPtr GetOutputParameterDesc;

            public IntPtr GetPatchConstantParameterDesc;

            public IntPtr GetVariableByName;

            public IntPtr GetResourceBindingDescByName;

            public IntPtr GetMovInstructionCount;

            public IntPtr GetMovcInstructionCount;

            public IntPtr GetConversionInstructionCount;

            public IntPtr GetBitwiseInstructionCount;

            public IntPtr GetGSInputPrimitive;

            public IntPtr IsSampleFrequencyShader;

            public IntPtr GetNumInterfaceSlots;

            public IntPtr GetMinFeatureLevel;

            public IntPtr GetThreadGroupSize;

            public IntPtr GetRequiresFlags;
        }
    }
}