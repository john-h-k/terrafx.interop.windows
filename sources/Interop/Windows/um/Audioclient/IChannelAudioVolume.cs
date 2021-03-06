// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C158861-B533-4B30-B1CF-E853E51C59B8")]
    public unsafe partial struct IChannelAudioVolume
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IChannelAudioVolume*, Guid*, void**, int>)(lpVtbl[0]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint>)(lpVtbl[1]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint>)(lpVtbl[2]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint*, int>)(lpVtbl[3]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint, float, Guid*, int>)(lpVtbl[4]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwIndex, fLevel, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint, float*, int>)(lpVtbl[5]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwIndex, pfLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint, float*, Guid*, int>)(lpVtbl[6]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("float *")] float* pfVolumes)
        {
            return ((delegate* stdcall<IChannelAudioVolume*, uint, float*, int>)(lpVtbl[7]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }
    }
}
