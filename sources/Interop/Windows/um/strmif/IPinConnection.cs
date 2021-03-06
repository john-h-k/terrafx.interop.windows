// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4A9A62D3-27D4-403D-91E9-89F540E55534")]
    public unsafe partial struct IPinConnection
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPinConnection*, Guid*, void**, int>)(lpVtbl[0]))((IPinConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPinConnection*, uint>)(lpVtbl[1]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPinConnection*, uint>)(lpVtbl[2]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DynamicQueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IPinConnection*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IPinConnection*)Unsafe.AsPointer(ref this), pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyEndOfStream([NativeTypeName("HANDLE")] IntPtr hNotifyEvent)
        {
            return ((delegate* stdcall<IPinConnection*, IntPtr, int>)(lpVtbl[4]))((IPinConnection*)Unsafe.AsPointer(ref this), hNotifyEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEndPin()
        {
            return ((delegate* stdcall<IPinConnection*, int>)(lpVtbl[5]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DynamicDisconnect()
        {
            return ((delegate* stdcall<IPinConnection*, int>)(lpVtbl[6]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }
    }
}
