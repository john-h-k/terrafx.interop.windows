// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30F3D47A-6447-11D1-8E3C-00C04FB9386D")]
    public unsafe partial struct IBlockingLock
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBlockingLock*, Guid*, void**, int>)(lpVtbl[0]))((IBlockingLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBlockingLock*, uint>)(lpVtbl[1]))((IBlockingLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBlockingLock*, uint>)(lpVtbl[2]))((IBlockingLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("DWORD")] uint dwTimeout)
        {
            return ((delegate* stdcall<IBlockingLock*, uint, int>)(lpVtbl[3]))((IBlockingLock*)Unsafe.AsPointer(ref this), dwTimeout);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unlock()
        {
            return ((delegate* stdcall<IBlockingLock*, int>)(lpVtbl[4]))((IBlockingLock*)Unsafe.AsPointer(ref this));
        }
    }
}
