// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09EF5BE3-C8A7-469E-8B70-73BF25BB193F")]
    public unsafe partial struct IMFObjectReferenceStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFObjectReferenceStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFObjectReferenceStream*, uint>)(lpVtbl[1]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFObjectReferenceStream*, uint>)(lpVtbl[2]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveReference([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* pUnk)
        {
            return ((delegate* stdcall<IMFObjectReferenceStream*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this), riid, pUnk);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadReference([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IMFObjectReferenceStream*, Guid*, void**, int>)(lpVtbl[4]))((IMFObjectReferenceStream*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
