// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("766C8FFB-5FDB-4FEA-A28D-B912996F51BD")]
    public unsafe partial struct IMFPMediaPlayerCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFPMediaPlayerCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFPMediaPlayerCallback*, uint>)(lpVtbl[1]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFPMediaPlayerCallback*, uint>)(lpVtbl[2]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnMediaPlayerEvent([NativeTypeName("MFP_EVENT_HEADER *")] MFP_EVENT_HEADER* pEventHeader)
        {
            ((delegate* stdcall<IMFPMediaPlayerCallback*, MFP_EVENT_HEADER*, void>)(lpVtbl[3]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this), pEventHeader);
        }
    }
}
