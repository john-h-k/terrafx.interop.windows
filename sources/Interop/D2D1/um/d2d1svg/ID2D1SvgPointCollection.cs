// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface describing an SVG 'points' value in a 'polyline' or 'polygon' element.</summary>
    [Guid("9DBE4C0D-3572-4DD9-9825-5530813BB712")]
    public unsafe partial struct ID2D1SvgPointCollection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgPointCollection* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgPointCollection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgPointCollection* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgPointCollection* This, ID2D1Factory** factory);

        /// <summary>Returns the element on which this attribute is set. Returns null if the attribute is not set on any element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetElement(ID2D1SvgPointCollection* This, ID2D1SvgElement** element);

        /// <summary>Creates a clone of this attribute value. On creation, the cloned attribute is not set on any element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(ID2D1SvgPointCollection* This, ID2D1SvgAttribute** attribute);

        /// <summary>Removes points from the end of the array.</summary>
        /// <param name="pointsCount">Specifies how many points to remove.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemovePointsAtEnd(ID2D1SvgPointCollection* This, [NativeTypeName("UINT32")] uint pointsCount);

        /// <summary>Updates the points array. Existing points not updated by this method are preserved. The array is resized larger if necessary to accomodate the new points.</summary>
        /// <param name="points">The points array.</param>
        /// <param name="pointsCount">The number of points to update.</param>
        /// <param name="startIndex">The index at which to begin updating points. Must be less than or equal to the size of the array.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdatePoints(ID2D1SvgPointCollection* This, [NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        /// <summary>Gets points from the points array.</summary>
        /// <param name="points">Buffer to contain the points.</param>
        /// <param name="pointsCount">The element count of the buffer.</param>
        /// <param name="startIndex">The index of the first point to retrieve.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPoints(ID2D1SvgPointCollection* This, [NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex = 0);

        /// <summary>Gets the number of points in the array.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetPointsCount(ID2D1SvgPointCollection* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        public void GetElement(ID2D1SvgElement** element)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)(This, element);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(ID2D1SvgAttribute** attribute)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(This, attribute);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePointsAtEnd([NativeTypeName("UINT32")] uint pointsCount)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemovePointsAtEnd>(lpVtbl->RemovePointsAtEnd)(This, pointsCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdatePoints([NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UpdatePoints>(lpVtbl->UpdatePoints)(This, points, pointsCount, startIndex);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPoints([NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPoints>(lpVtbl->GetPoints)(This, points, pointsCount, startIndex);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPointsCount()
        {
            fixed (ID2D1SvgPointCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPointsCount>(lpVtbl->GetPointsCount)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetElement;

            public IntPtr Clone;

            public IntPtr RemovePointsAtEnd;

            public IntPtr UpdatePoints;

            public IntPtr GetPoints;

            public IntPtr GetPointsCount;
        }
    }
}