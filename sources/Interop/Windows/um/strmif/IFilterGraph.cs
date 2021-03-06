// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689F-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IFilterGraph
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IFilterGraph*, Guid*, void**, int>)(lpVtbl[0]))((IFilterGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IFilterGraph*, uint>)(lpVtbl[1]))((IFilterGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IFilterGraph*, uint>)(lpVtbl[2]))((IFilterGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* stdcall<IFilterGraph*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IFilterGraph*)Unsafe.AsPointer(ref this), pFilter, pName);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* stdcall<IFilterGraph*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterGraph*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumFilters([NativeTypeName("IEnumFilters **")] IEnumFilters** ppEnum)
        {
            return ((delegate* stdcall<IFilterGraph*, IEnumFilters**, int>)(lpVtbl[5]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* stdcall<IFilterGraph*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IFilterGraph*)Unsafe.AsPointer(ref this), pName, ppFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectDirect([NativeTypeName("IPin *")] IPin* ppinOut, [NativeTypeName("IPin *")] IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IFilterGraph*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* stdcall<IFilterGraph*, IPin*, int>)(lpVtbl[8]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppin);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* stdcall<IFilterGraph*, IPin*, int>)(lpVtbl[9]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppin);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSyncSource()
        {
            return ((delegate* stdcall<IFilterGraph*, int>)(lpVtbl[10]))((IFilterGraph*)Unsafe.AsPointer(ref this));
        }
    }
}
