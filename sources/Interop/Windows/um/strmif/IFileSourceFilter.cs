// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A6-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IFileSourceFilter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IFileSourceFilter*, Guid*, void**, int>)(lpVtbl[0]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IFileSourceFilter*, uint>)(lpVtbl[1]))((IFileSourceFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IFileSourceFilter*, uint>)(lpVtbl[2]))((IFileSourceFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IFileSourceFilter*, ushort*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), pszFileName, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IFileSourceFilter*, ushort**, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IFileSourceFilter*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
        }
    }
}
