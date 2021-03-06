// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2CD3A4B-AF25-4D3D-9110-DA0E6F8EE877")]
    public unsafe partial struct IMFSourceBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, uint>)(lpVtbl[1]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, uint>)(lpVtbl[2]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetUpdating()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, int>)(lpVtbl[3]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffered([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, IMFMediaTimeRange**, int>)(lpVtbl[4]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        public double GetTimeStampOffset()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double>)(lpVtbl[5]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTimeStampOffset(double offset)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double, int>)(lpVtbl[6]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), offset);
        }

        public double GetAppendWindowStart()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double>)(lpVtbl[7]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAppendWindowStart(double time)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double, int>)(lpVtbl[8]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
        }

        public double GetAppendWindowEnd()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double>)(lpVtbl[9]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAppendWindowEnd(double time)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double, int>)(lpVtbl[10]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
        }

        [return: NativeTypeName("HRESULT")]
        public int Append([NativeTypeName("const BYTE *")] byte* pData, [NativeTypeName("DWORD")] uint len)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, byte*, uint, int>)(lpVtbl[11]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pData, len);
        }

        [return: NativeTypeName("HRESULT")]
        public int AppendByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pStream, [NativeTypeName("DWORDLONG *")] ulong* pMaxLen)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)(lpVtbl[12]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pStream, pMaxLen);
        }

        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* stdcall<IMFSourceBuffer*, int>)(lpVtbl[13]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Remove(double start, double end)
        {
            return ((delegate* stdcall<IMFSourceBuffer*, double, double, int>)(lpVtbl[14]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), start, end);
        }
    }
}
