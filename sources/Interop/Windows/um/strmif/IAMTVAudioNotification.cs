// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83EC1C33-23D1-11D1-99E6-00A0C9560266")]
    public unsafe partial struct IAMTVAudioNotification
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMTVAudioNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMTVAudioNotification*, uint>)(lpVtbl[1]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMTVAudioNotification*, uint>)(lpVtbl[2]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnEvent(AMTVAudioEventType Event)
        {
            return ((delegate* stdcall<IAMTVAudioNotification*, AMTVAudioEventType, int>)(lpVtbl[3]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this), Event);
        }
    }
}
