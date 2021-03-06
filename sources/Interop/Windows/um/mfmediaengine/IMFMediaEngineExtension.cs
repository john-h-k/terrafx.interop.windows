// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F69D622-20B5-41E9-AFDF-89CED1DDA04E")]
    public unsafe partial struct IMFMediaEngineExtension
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, uint>)(lpVtbl[1]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, uint>)(lpVtbl[2]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BOOL")] int AudioOnly, [NativeTypeName("BSTR")] ushort* MimeType, [NativeTypeName("MF_MEDIA_ENGINE_CANPLAY *")] MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, int, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[3]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), AudioOnly, MimeType, pAnswer);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginCreateObject([NativeTypeName("BSTR")] ushort* bstrURL, [NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, MF_OBJECT_TYPE type, [NativeTypeName("IUnknown **")] IUnknown** ppIUnknownCancelCookie, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, ushort*, IMFByteStream*, MF_OBJECT_TYPE, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelObjectCreation([NativeTypeName("IUnknown *")] IUnknown* pIUnknownCancelCookie)
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, IUnknown*, int>)(lpVtbl[5]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndCreateObject([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IUnknown **")] IUnknown** ppObject)
        {
            return ((delegate* stdcall<IMFMediaEngineExtension*, IMFAsyncResult*, IUnknown**, int>)(lpVtbl[6]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), pResult, ppObject);
        }
    }
}
