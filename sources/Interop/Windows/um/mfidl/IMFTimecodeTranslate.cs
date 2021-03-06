// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AB9D8661-F7E8-4EF4-9861-89F334F94E74")]
    public unsafe partial struct IMFTimecodeTranslate
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, uint>)(lpVtbl[1]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, uint>)(lpVtbl[2]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginConvertTimecodeToHNS([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVarTimecode, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, PROPVARIANT*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pPropVarTimecode, pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndConvertTimecodeToHNS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("MFTIME *")] long* phnsTime)
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, IMFAsyncResult*, long*, int>)(lpVtbl[4]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pResult, phnsTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginConvertHNSToTimecode([NativeTypeName("MFTIME")] long hnsTime, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, long, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), hnsTime, pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndConvertHNSToTimecode([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarTimecode)
        {
            return ((delegate* stdcall<IMFTimecodeTranslate*, IMFAsyncResult*, PROPVARIANT*, int>)(lpVtbl[6]))((IMFTimecodeTranslate*)Unsafe.AsPointer(ref this), pResult, pPropVarTimecode);
        }
    }
}
