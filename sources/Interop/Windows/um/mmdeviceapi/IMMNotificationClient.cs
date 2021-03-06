// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0")]
    public unsafe partial struct IMMNotificationClient
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMMNotificationClient*, Guid*, void**, int>)(lpVtbl[0]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMMNotificationClient*, uint>)(lpVtbl[1]))((IMMNotificationClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMMNotificationClient*, uint>)(lpVtbl[2]))((IMMNotificationClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDeviceStateChanged([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId, [NativeTypeName("DWORD")] uint dwNewState)
        {
            return ((delegate* stdcall<IMMNotificationClient*, ushort*, uint, int>)(lpVtbl[3]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId, dwNewState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDeviceAdded([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId)
        {
            return ((delegate* stdcall<IMMNotificationClient*, ushort*, int>)(lpVtbl[4]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDeviceRemoved([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId)
        {
            return ((delegate* stdcall<IMMNotificationClient*, ushort*, int>)(lpVtbl[5]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDefaultDeviceChanged(EDataFlow flow, ERole role, [NativeTypeName("LPCWSTR")] ushort* pwstrDefaultDeviceId)
        {
            return ((delegate* stdcall<IMMNotificationClient*, EDataFlow, ERole, ushort*, int>)(lpVtbl[6]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), flow, role, pwstrDefaultDeviceId);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnPropertyValueChanged([NativeTypeName("LPCWSTR")] ushort* pwstrDeviceId, [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key)
        {
            return ((delegate* stdcall<IMMNotificationClient*, ushort*, PROPERTYKEY, int>)(lpVtbl[7]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId, key);
        }
    }
}
