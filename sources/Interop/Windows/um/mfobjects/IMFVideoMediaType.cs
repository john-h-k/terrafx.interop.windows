// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B99F381F-A8F9-47A2-A5AF-CA3A225A3890")]
    public unsafe partial struct IMFVideoMediaType
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoMediaType*, uint>)(lpVtbl[1]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoMediaType*, uint>)(lpVtbl[2]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, uint*, int>)(lpVtbl[7]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, double*, int>)(lpVtbl[9]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, uint*, int>)(lpVtbl[11]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, uint*, int>)(lpVtbl[14]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, int>)(lpVtbl[19]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* stdcall<IMFVideoMediaType*, int>)(lpVtbl[20]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, uint, int>)(lpVtbl[21]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, ulong, int>)(lpVtbl[22]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, double, int>)(lpVtbl[23]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* stdcall<IMFVideoMediaType*, int>)(lpVtbl[28]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* stdcall<IMFVideoMediaType*, int>)(lpVtbl[29]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, uint*, int>)(lpVtbl[30]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pcItems);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, IMFAttributes*, int>)(lpVtbl[32]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMajorType([NativeTypeName("GUID *")] Guid* pguidMajorType)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid*, int>)(lpVtbl[33]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pguidMajorType);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsCompressedFormat([NativeTypeName("BOOL *")] int* pfCompressed)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, int*, int>)(lpVtbl[34]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pfCompressed);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IMFMediaType *")] IMFMediaType* pIMediaType, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, IMFMediaType*, uint*, int>)(lpVtbl[35]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pIMediaType, pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID *")] void** ppvRepresentation)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid, void**, int>)(lpVtbl[36]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, ppvRepresentation);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid, void*, int>)(lpVtbl[37]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, pvRepresentation);
        }

        [return: NativeTypeName("const MFVIDEOFORMAT *")]
        public MFVIDEOFORMAT* GetVideoFormat()
        {
            return ((delegate* stdcall<IMFVideoMediaType*, MFVIDEOFORMAT*>)(lpVtbl[38]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID *")] void** ppvRepresentation, [NativeTypeName("LONG")] int lStride)
        {
            return ((delegate* stdcall<IMFVideoMediaType*, Guid, void**, int, int>)(lpVtbl[39]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, ppvRepresentation, lStride);
        }
    }
}
