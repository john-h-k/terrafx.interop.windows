// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("379A0CF0-C1DE-11D2-ABF5-00A0C905F375")]
    public unsafe partial struct IMemAllocatorCallbackTemp
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, uint>)(lpVtbl[1]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, uint>)(lpVtbl[2]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetProperties([NativeTypeName("ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pRequest, [NativeTypeName("ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pActual)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[3]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pRequest, pActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[4]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pProps);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, int>)(lpVtbl[5]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Decommit()
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, int>)(lpVtbl[6]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("IMediaSample **")] IMediaSample** ppBuffer, [NativeTypeName("REFERENCE_TIME *")] long* pStartTime, [NativeTypeName("REFERENCE_TIME *")] long* pEndTime, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, IMediaSample**, long*, long*, uint, int>)(lpVtbl[7]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), ppBuffer, pStartTime, pEndTime, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseBuffer([NativeTypeName("IMediaSample *")] IMediaSample* pBuffer)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, IMediaSample*, int>)(lpVtbl[8]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotify([NativeTypeName("IMemAllocatorNotifyCallbackTemp *")] IMemAllocatorNotifyCallbackTemp* pNotify)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, IMemAllocatorNotifyCallbackTemp*, int>)(lpVtbl[9]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pNotify);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFreeCount([NativeTypeName("LONG *")] int* plBuffersFree)
        {
            return ((delegate* stdcall<IMemAllocatorCallbackTemp*, int*, int>)(lpVtbl[10]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), plBuffersFree);
        }
    }
}
