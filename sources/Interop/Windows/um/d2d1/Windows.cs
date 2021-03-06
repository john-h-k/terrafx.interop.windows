// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d2d1", EntryPoint = "D2D1CreateFactory", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, [NativeTypeName("void **")] void** ppIFactory);

        [DllImport("d2d1", EntryPoint = "D2D1MakeRotateMatrix", ExactSpelling = true)]
        public static extern void D2D1MakeRotateMatrix([NativeTypeName("FLOAT")] float angle, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", EntryPoint = "D2D1MakeSkewMatrix", ExactSpelling = true)]
        public static extern void D2D1MakeSkewMatrix([NativeTypeName("FLOAT")] float angleX, [NativeTypeName("FLOAT")] float angleY, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", EntryPoint = "D2D1IsMatrixInvertible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1IsMatrixInvertible([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", EntryPoint = "D2D1InvertMatrix", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1InvertMatrix([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [return: NativeTypeName("HRESULT")]
        public static int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** factory)
        {
            return D2D1CreateFactory(factoryType, riid, null, factory);
        }

        [NativeTypeName("#define D2D1_DEFAULT_FLATTENING_TOLERANCE (0.25f)")]
        public const float D2D1_DEFAULT_FLATTENING_TOLERANCE = (0.25f);
    }
}
