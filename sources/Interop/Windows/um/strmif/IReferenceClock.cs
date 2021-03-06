// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86897-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IReferenceClock
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IReferenceClock*, Guid*, void**, int>)(lpVtbl[0]))((IReferenceClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IReferenceClock*, uint>)(lpVtbl[1]))((IReferenceClock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IReferenceClock*, uint>)(lpVtbl[2]))((IReferenceClock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTime)
        {
            return ((delegate* stdcall<IReferenceClock*, long*, int>)(lpVtbl[3]))((IReferenceClock*)Unsafe.AsPointer(ref this), pTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int AdviseTime([NativeTypeName("REFERENCE_TIME")] long baseTime, [NativeTypeName("REFERENCE_TIME")] long streamTime, [NativeTypeName("HEVENT")] nuint hEvent, [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie)
        {
            return ((delegate* stdcall<IReferenceClock*, long, long, nuint, nuint*, int>)(lpVtbl[4]))((IReferenceClock*)Unsafe.AsPointer(ref this), baseTime, streamTime, hEvent, pdwAdviseCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int AdvisePeriodic([NativeTypeName("REFERENCE_TIME")] long startTime, [NativeTypeName("REFERENCE_TIME")] long periodTime, [NativeTypeName("HSEMAPHORE")] nuint hSemaphore, [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie)
        {
            return ((delegate* stdcall<IReferenceClock*, long, long, nuint, nuint*, int>)(lpVtbl[5]))((IReferenceClock*)Unsafe.AsPointer(ref this), startTime, periodTime, hSemaphore, pdwAdviseCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD_PTR")] nuint dwAdviseCookie)
        {
            return ((delegate* stdcall<IReferenceClock*, nuint, int>)(lpVtbl[6]))((IReferenceClock*)Unsafe.AsPointer(ref this), dwAdviseCookie);
        }
    }
}
