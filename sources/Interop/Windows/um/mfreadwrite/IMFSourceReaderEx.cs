// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B981CF0-560E-4116-9875-B099895F23D7")]
    public unsafe partial struct IMFSourceReaderEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint>)(lpVtbl[1]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint>)(lpVtbl[2]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pfSelected)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, int*, int>)(lpVtbl[3]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pfSelected);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fSelected)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, int, int>)(lpVtbl[4]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, fSelected);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwMediaTypeIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, IMFMediaType**, int>)(lpVtbl[6]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, uint*, IMFMediaType*, int>)(lpVtbl[7]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwReserved, pMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), guidTimeFormat, varPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, [NativeTypeName("IMFSample **")] IMFSample** ppSample)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, uint, uint*, uint*, long*, IMFSample**, int>)(lpVtbl[9]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwControlFlags, pdwActualStreamIndex, pdwStreamFlags, pllTimestamp, ppSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, int>)(lpVtbl[10]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, Guid*, Guid*, void**, int>)(lpVtbl[11]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarAttribute)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[12]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidAttribute, pvarAttribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamFlags)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, IMFMediaType*, uint*, int>)(lpVtbl[13]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaType, pdwStreamFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IUnknown *")] IUnknown* pTransformOrActivate)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, IUnknown*, int>)(lpVtbl[14]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pTransformOrActivate);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllTransformsForStream([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, int>)(lpVtbl[15]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, [NativeTypeName("GUID *")] Guid* pGuidCategory, [NativeTypeName("IMFTransform **")] IMFTransform** ppTransform)
        {
            return ((delegate* stdcall<IMFSourceReaderEx*, uint, uint, Guid*, IMFTransform**, int>)(lpVtbl[16]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwTransformIndex, pGuidCategory, ppTransform);
        }
    }
}
