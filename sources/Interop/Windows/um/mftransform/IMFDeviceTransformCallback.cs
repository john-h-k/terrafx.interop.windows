// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D5CB646-29EC-41FB-8179-8C4C6D750811")]
    public unsafe partial struct IMFDeviceTransformCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFDeviceTransformCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFDeviceTransformCallback*, uint>)(lpVtbl[1]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFDeviceTransformCallback*, uint>)(lpVtbl[2]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnBufferSent([NativeTypeName("IMFAttributes *")] IMFAttributes* pCallbackAttributes, [NativeTypeName("DWORD")] uint pinId)
        {
            return ((delegate* stdcall<IMFDeviceTransformCallback*, IMFAttributes*, uint, int>)(lpVtbl[3]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this), pCallbackAttributes, pinId);
        }
    }
}
