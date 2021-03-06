// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACE-2F86-11D1-8E04-00C04FB9989A")]
    public unsafe partial struct IPipeDouble
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPipeDouble*, Guid*, void**, int>)(lpVtbl[0]))((IPipeDouble*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPipeDouble*, uint>)(lpVtbl[1]))((IPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPipeDouble*, uint>)(lpVtbl[2]))((IPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pull([NativeTypeName("DOUBLE *")] double* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* stdcall<IPipeDouble*, double*, uint, uint*, int>)(lpVtbl[3]))((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int Push([NativeTypeName("DOUBLE *")] double* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* stdcall<IPipeDouble*, double*, uint, int>)(lpVtbl[4]))((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cSent);
        }
    }
}
