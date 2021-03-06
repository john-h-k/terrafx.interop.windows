// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD4C1B00-4BF7-422F-9175-756693D9130D")]
    public unsafe partial struct IMFByteStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFByteStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFByteStream*, uint>)(lpVtbl[1]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFByteStream*, uint>)(lpVtbl[2]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapabilities)
        {
            return ((delegate* stdcall<IMFByteStream*, uint*, int>)(lpVtbl[3]))((IMFByteStream*)Unsafe.AsPointer(ref this), pdwCapabilities);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLength([NativeTypeName("QWORD *")] ulong* pqwLength)
        {
            return ((delegate* stdcall<IMFByteStream*, ulong*, int>)(lpVtbl[4]))((IMFByteStream*)Unsafe.AsPointer(ref this), pqwLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLength([NativeTypeName("QWORD")] ulong qwLength)
        {
            return ((delegate* stdcall<IMFByteStream*, ulong, int>)(lpVtbl[5]))((IMFByteStream*)Unsafe.AsPointer(ref this), qwLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPosition([NativeTypeName("QWORD *")] ulong* pqwPosition)
        {
            return ((delegate* stdcall<IMFByteStream*, ulong*, int>)(lpVtbl[6]))((IMFByteStream*)Unsafe.AsPointer(ref this), pqwPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentPosition([NativeTypeName("QWORD")] ulong qwPosition)
        {
            return ((delegate* stdcall<IMFByteStream*, ulong, int>)(lpVtbl[7]))((IMFByteStream*)Unsafe.AsPointer(ref this), qwPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEndOfStream([NativeTypeName("BOOL *")] int* pfEndOfStream)
        {
            return ((delegate* stdcall<IMFByteStream*, int*, int>)(lpVtbl[8]))((IMFByteStream*)Unsafe.AsPointer(ref this), pfEndOfStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<IMFByteStream*, byte*, uint, uint*, int>)(lpVtbl[9]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginRead([NativeTypeName("BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFByteStream*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[10]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndRead([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<IMFByteStream*, IMFAsyncResult*, uint*, int>)(lpVtbl[11]))((IMFByteStream*)Unsafe.AsPointer(ref this), pResult, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<IMFByteStream*, byte*, uint, uint*, int>)(lpVtbl[12]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginWrite([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFByteStream*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[13]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndWrite([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<IMFByteStream*, IMFAsyncResult*, uint*, int>)(lpVtbl[14]))((IMFByteStream*)Unsafe.AsPointer(ref this), pResult, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(MFBYTESTREAM_SEEK_ORIGIN SeekOrigin, [NativeTypeName("LONGLONG")] long llSeekOffset, [NativeTypeName("DWORD")] uint dwSeekFlags, [NativeTypeName("QWORD *")] ulong* pqwCurrentPosition)
        {
            return ((delegate* stdcall<IMFByteStream*, MFBYTESTREAM_SEEK_ORIGIN, long, uint, ulong*, int>)(lpVtbl[15]))((IMFByteStream*)Unsafe.AsPointer(ref this), SeekOrigin, llSeekOffset, dwSeekFlags, pqwCurrentPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* stdcall<IMFByteStream*, int>)(lpVtbl[16]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<IMFByteStream*, int>)(lpVtbl[17]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }
    }
}
