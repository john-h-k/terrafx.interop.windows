// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Describes a geometric path that does not contain quadratic bezier curves or arcs.</summary>
    [Guid("2CD9069E-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1SimplifiedGeometrySink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SimplifiedGeometrySink* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SimplifiedGeometrySink* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SimplifiedGeometrySink* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetFillMode(ID2D1SimplifiedGeometrySink* This, D2D1_FILL_MODE fillMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetSegmentFlags(ID2D1SimplifiedGeometrySink* This, D2D1_PATH_SEGMENT vertexFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginFigure(ID2D1SimplifiedGeometrySink* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AddLines(ID2D1SimplifiedGeometrySink* This, [NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AddBeziers(ID2D1SimplifiedGeometrySink* This, [NativeTypeName("D2D1_BEZIER_SEGMENT[]")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EndFigure(ID2D1SimplifiedGeometrySink* This, D2D1_FIGURE_END figureEnd);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID2D1SimplifiedGeometrySink* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void SetFillMode(D2D1_FILL_MODE fillMode)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetFillMode>(lpVtbl->SetFillMode)(This, fillMode);
            }
        }

        public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetSegmentFlags>(lpVtbl->SetSegmentFlags)(This, vertexFlags);
            }
        }

        public void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginFigure>(lpVtbl->BeginFigure)(This, startPoint, figureBegin);
            }
        }

        public void AddLines([NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_AddLines>(lpVtbl->AddLines)(This, points, pointsCount);
            }
        }

        public void AddBeziers([NativeTypeName("D2D1_BEZIER_SEGMENT[]")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_AddBeziers>(lpVtbl->AddBeziers)(This, beziers, beziersCount);
            }
        }

        public void EndFigure(D2D1_FIGURE_END figureEnd)
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EndFigure>(lpVtbl->EndFigure)(This, figureEnd);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            fixed (ID2D1SimplifiedGeometrySink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetFillMode;

            public IntPtr SetSegmentFlags;

            public IntPtr BeginFigure;

            public IntPtr AddLines;

            public IntPtr AddBeziers;

            public IntPtr EndFigure;

            public IntPtr Close;
        }
    }
}