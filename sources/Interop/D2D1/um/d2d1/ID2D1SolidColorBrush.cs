// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Paints an area with a solid color.</summary>
    [Guid("2CD906A9-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1SolidColorBrush
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SolidColorBrush* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SolidColorBrush* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SolidColorBrush* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SolidColorBrush* This, ID2D1Factory** factory);

        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOpacity(ID2D1SolidColorBrush* This, [NativeTypeName("FLOAT")] float opacity);

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1SolidColorBrush* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetOpacity(ID2D1SolidColorBrush* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1SolidColorBrush* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetColor(ID2D1SolidColorBrush* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_COLOR_F")]
        public delegate DXGI_RGBA* _GetColor(ID2D1SolidColorBrush* This, DXGI_RGBA* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetOpacity>(lpVtbl->SetOpacity)(This, opacity);
            }
        }

        public void SetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(This, transform);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetOpacity>(lpVtbl->GetOpacity)(This);
            }
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(This, transform);
            }
        }

        public void SetColor([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color)
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetColor>(lpVtbl->SetColor)(This, color);
            }
        }

        [return: NativeTypeName("D2D1_COLOR_F")]
        public DXGI_RGBA GetColor()
        {
            fixed (ID2D1SolidColorBrush* This = &this)
            {
                DXGI_RGBA result;
                return *Marshal.GetDelegateForFunctionPointer<_GetColor>(lpVtbl->GetColor)(This, &result);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetOpacity;

            public IntPtr SetTransform;

            public IntPtr GetOpacity;

            public IntPtr GetTransform;

            public IntPtr SetColor;

            public IntPtr GetColor;
        }
    }
}