// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A8809222-07BB-48EA-951C-33158100625B")]
    public unsafe partial struct IGetCapabilitiesKey
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IGetCapabilitiesKey*, Guid*, void**, int>)(lpVtbl[0]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IGetCapabilitiesKey*, uint>)(lpVtbl[1]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IGetCapabilitiesKey*, uint>)(lpVtbl[2]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCapabilitiesKey([NativeTypeName("HKEY *")] IntPtr* pHKey)
        {
            return ((delegate* stdcall<IGetCapabilitiesKey*, IntPtr*, int>)(lpVtbl[3]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), pHKey);
        }
    }
}
