// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24918ACC-64B3-37C1-8CA9-74A66E9957A8")]
    public unsafe partial struct IAudioSessionEvents
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioSessionEvents*, uint>)(lpVtbl[1]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioSessionEvents*, uint>)(lpVtbl[2]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDisplayNameChanged([NativeTypeName("LPCWSTR")] ushort* NewDisplayName, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, ushort*, Guid*, int>)(lpVtbl[3]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), NewDisplayName, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnIconPathChanged([NativeTypeName("LPCWSTR")] ushort* NewIconPath, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, ushort*, Guid*, int>)(lpVtbl[4]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), NewIconPath, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnSimpleVolumeChanged(float NewVolume, [NativeTypeName("BOOL")] int NewMute, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, float, int, Guid*, int>)(lpVtbl[5]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), NewVolume, NewMute, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnChannelVolumeChanged([NativeTypeName("DWORD")] uint ChannelCount, [NativeTypeName("float []")] float* NewChannelVolumeArray, [NativeTypeName("DWORD")] uint ChangedChannel, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, uint, float*, uint, Guid*, int>)(lpVtbl[6]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), ChannelCount, NewChannelVolumeArray, ChangedChannel, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnGroupingParamChanged([NativeTypeName("LPCGUID")] Guid* NewGroupingParam, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, Guid*, Guid*, int>)(lpVtbl[7]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), NewGroupingParam, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStateChanged(AudioSessionState NewState)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, AudioSessionState, int>)(lpVtbl[8]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), NewState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnSessionDisconnected(AudioSessionDisconnectReason DisconnectReason)
        {
            return ((delegate* stdcall<IAudioSessionEvents*, AudioSessionDisconnectReason, int>)(lpVtbl[9]))((IAudioSessionEvents*)Unsafe.AsPointer(ref this), DisconnectReason);
        }
    }
}
