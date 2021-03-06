// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CF-0000-0000-C000-000000000046")]
    public unsafe partial struct IMarshal2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMarshal2*, Guid*, void**, int>)(lpVtbl[0]))((IMarshal2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMarshal2*, uint>)(lpVtbl[1]))((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMarshal2*, uint>)(lpVtbl[2]))((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
        {
            return ((delegate* stdcall<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)(lpVtbl[3]))((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
        {
            return ((delegate* stdcall<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int MarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
        {
            return ((delegate* stdcall<IMarshal2*, IStream*, Guid*, void*, uint, void*, uint, int>)(lpVtbl[5]))((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnmarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IMarshal2*, IStream*, Guid*, void**, int>)(lpVtbl[6]))((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseMarshalData([NativeTypeName("IStream *")] IStream* pStm)
        {
            return ((delegate* stdcall<IMarshal2*, IStream*, int>)(lpVtbl[7]))((IMarshal2*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IMarshal2*, uint, int>)(lpVtbl[8]))((IMarshal2*)Unsafe.AsPointer(ref this), dwReserved);
        }
    }
}
