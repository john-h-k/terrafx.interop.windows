// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CA86AA50-C46E-429E-AB27-16D6AC6844CB")]
    public unsafe partial struct IMFSampleGrabberSinkCallback2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, uint>)(lpVtbl[1]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, uint>)(lpVtbl[2]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, long, long, int>)(lpVtbl[3]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, long, int>)(lpVtbl[4]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, long, int>)(lpVtbl[5]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, long, int>)(lpVtbl[6]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, long, float, int>)(lpVtbl[7]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnSetPresentationClock([NativeTypeName("IMFPresentationClock *")] IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, IMFPresentationClock*, int>)(lpVtbl[8]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProcessSample([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, Guid*, uint, long, long, byte*, uint, int>)(lpVtbl[9]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), guidMajorMediaType, dwSampleFlags, llSampleTime, llSampleDuration, pSampleBuffer, dwSampleSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnShutdown()
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, int>)(lpVtbl[10]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProcessSampleEx([NativeTypeName("const GUID &")] Guid* guidMajorMediaType, [NativeTypeName("DWORD")] uint dwSampleFlags, [NativeTypeName("LONGLONG")] long llSampleTime, [NativeTypeName("LONGLONG")] long llSampleDuration, [NativeTypeName("const BYTE *")] byte* pSampleBuffer, [NativeTypeName("DWORD")] uint dwSampleSize, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes)
        {
            return ((delegate* stdcall<IMFSampleGrabberSinkCallback2*, Guid*, uint, long, long, byte*, uint, IMFAttributes*, int>)(lpVtbl[11]))((IMFSampleGrabberSinkCallback2*)Unsafe.AsPointer(ref this), guidMajorMediaType, dwSampleFlags, llSampleTime, llSampleDuration, pSampleBuffer, dwSampleSize, pAttributes);
        }
    }
}
