// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by a transform author.</summary>
    [Guid("EF1A287D-342A-4F76-8FDB-DA0D6EA9F92B")]
    public unsafe struct ID2D1Transform
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Transform* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Transform* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Transform* This
        );
        #endregion

        #region ID2D1TransformNode Delegates
        /// <summary>Return the number of input this node has.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetInputCount(
            [In] ID2D1Transform* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MapOutputRectToInputRects(
            [In] ID2D1Transform* This,
            [In, NativeTypeName("D2D1_RECT_L")] RECT* outputRect,
            [Out, NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects,
            [In, NativeTypeName("UINT32")] uint inputRectsCount
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MapInputRectsToOutputRect(
            [In] ID2D1Transform* This,
            [In, NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects,
            [In, NativeTypeName("D2D1_RECT_L[]")] RECT* inputOpaqueSubRects,
            [In, NativeTypeName("UINT32")] uint inputRectCount,
            [Out, NativeTypeName("D2D1_RECT_L")] RECT* outputRect,
            [Out, NativeTypeName("D2D1_RECT_L")] RECT* outputOpaqueSubRect
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MapInvalidRect(
            [In] ID2D1Transform* This,
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In, NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect,
            [Out, NativeTypeName("D2D1_RECT_L")] RECT* invalidOutputRect
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Transform* This = &this)
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
            fixed (ID2D1Transform* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Transform* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1TransformNode Methods
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1Transform* This = &this)
            {
                return MarshalFunction<_GetInputCount>(lpVtbl->GetInputCount)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects(
            [In, NativeTypeName("D2D1_RECT_L")] RECT* outputRect,
            [Out, NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects,
            [In, NativeTypeName("UINT32")] uint inputRectsCount
        )
        {
            fixed (ID2D1Transform* This = &this)
            {
                return MarshalFunction<_MapOutputRectToInputRects>(lpVtbl->MapOutputRectToInputRects)(
                    This,
                    outputRect,
                    inputRects,
                    inputRectsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect(
            [In, NativeTypeName("D2D1_RECT_L[]")] RECT* inputRects,
            [In, NativeTypeName("D2D1_RECT_L[]")] RECT* inputOpaqueSubRects,
            [In, NativeTypeName("UINT32")] uint inputRectCount,
            [Out, NativeTypeName("D2D1_RECT_L")] RECT* outputRect,
            [Out, NativeTypeName("D2D1_RECT_L")] RECT* outputOpaqueSubRect
        )
        {
            fixed (ID2D1Transform* This = &this)
            {
                return MarshalFunction<_MapInputRectsToOutputRect>(lpVtbl->MapInputRectsToOutputRect)(
                    This,
                    inputRects,
                    inputOpaqueSubRects,
                    inputRectCount,
                    outputRect,
                    outputOpaqueSubRect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect(
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In, NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect,
            [Out, NativeTypeName("D2D1_RECT_L")] RECT* invalidOutputRect
        )
        {
            fixed (ID2D1Transform* This = &this)
            {
                return MarshalFunction<_MapInvalidRect>(lpVtbl->MapInvalidRect)(
                    This,
                    inputIndex,
                    invalidInputRect,
                    invalidOutputRect
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

            #region ID2D1TransformNode Fields
            public IntPtr GetInputCount;
            #endregion

            #region Fields
            public IntPtr MapOutputRectToInputRects;

            public IntPtr MapInputRectsToOutputRect;

            public IntPtr MapInvalidRect;
            #endregion
        }
        #endregion
    }
}