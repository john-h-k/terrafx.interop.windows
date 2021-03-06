// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75121952-E0D0-43E5-9380-1D80483ACF72")]
    public unsafe partial struct ICreateObject
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICreateObject*, Guid*, void**, int>)(lpVtbl[0]))((ICreateObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICreateObject*, uint>)(lpVtbl[1]))((ICreateObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICreateObject*, uint>)(lpVtbl[2]))((ICreateObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateObject([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<ICreateObject*, Guid*, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((ICreateObject*)Unsafe.AsPointer(ref this), clsid, pUnkOuter, riid, ppv);
        }
    }
}
