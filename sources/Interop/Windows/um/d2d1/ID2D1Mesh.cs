// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906C2-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1Mesh
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1Mesh*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Mesh*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1Mesh*, uint>)(lpVtbl[1]))((ID2D1Mesh*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1Mesh*, uint>)(lpVtbl[2]))((ID2D1Mesh*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1Mesh*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Mesh*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("ID2D1TessellationSink **")] ID2D1TessellationSink** tessellationSink)
        {
            return ((delegate* stdcall<ID2D1Mesh*, ID2D1TessellationSink**, int>)(lpVtbl[4]))((ID2D1Mesh*)Unsafe.AsPointer(ref this), tessellationSink);
        }
    }
}
