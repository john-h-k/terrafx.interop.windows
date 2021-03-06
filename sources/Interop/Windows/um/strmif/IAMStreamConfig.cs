// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13340-30AC-11D0-A18C-00A0C9118956")]
    public unsafe partial struct IAMStreamConfig
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMStreamConfig*, Guid*, void**, int>)(lpVtbl[0]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMStreamConfig*, uint>)(lpVtbl[1]))((IAMStreamConfig*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMStreamConfig*, uint>)(lpVtbl[2]))((IAMStreamConfig*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFormat([NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IAMStreamConfig*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppmt)
        {
            return ((delegate* stdcall<IAMStreamConfig*, AM_MEDIA_TYPE**, int>)(lpVtbl[4]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), ppmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfCapabilities([NativeTypeName("int *")] int* piCount, [NativeTypeName("int *")] int* piSize)
        {
            return ((delegate* stdcall<IAMStreamConfig*, int*, int*, int>)(lpVtbl[5]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), piCount, piSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamCaps(int iIndex, [NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppmt, [NativeTypeName("BYTE *")] byte* pSCC)
        {
            return ((delegate* stdcall<IAMStreamConfig*, int, AM_MEDIA_TYPE**, byte*, int>)(lpVtbl[6]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), iIndex, ppmt, pSCC);
        }
    }
}
