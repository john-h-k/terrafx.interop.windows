// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
    public unsafe partial struct ICreateDevEnum
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICreateDevEnum*, Guid*, void**, int>)(lpVtbl[0]))((ICreateDevEnum*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICreateDevEnum*, uint>)(lpVtbl[1]))((ICreateDevEnum*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICreateDevEnum*, uint>)(lpVtbl[2]))((ICreateDevEnum*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClassEnumerator([NativeTypeName("const IID &")] Guid* clsidDeviceClass, [NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppEnumMoniker, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<ICreateDevEnum*, Guid*, IEnumMoniker**, uint, int>)(lpVtbl[3]))((ICreateDevEnum*)Unsafe.AsPointer(ref this), clsidDeviceClass, ppEnumMoniker, dwFlags);
        }
    }
}
