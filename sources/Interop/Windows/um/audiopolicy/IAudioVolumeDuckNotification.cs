// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3B284D4-6D39-4359-B3CF-B56DDB3BB39C")]
    public unsafe partial struct IAudioVolumeDuckNotification
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioVolumeDuckNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioVolumeDuckNotification*, uint>)(lpVtbl[1]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioVolumeDuckNotification*, uint>)(lpVtbl[2]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnVolumeDuckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID, [NativeTypeName("UINT32")] uint countCommunicationSessions)
        {
            return ((delegate* stdcall<IAudioVolumeDuckNotification*, ushort*, uint, int>)(lpVtbl[3]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), sessionID, countCommunicationSessions);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnVolumeUnduckNotification([NativeTypeName("LPCWSTR")] ushort* sessionID)
        {
            return ((delegate* stdcall<IAudioVolumeDuckNotification*, ushort*, int>)(lpVtbl[4]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), sessionID);
        }
    }
}
