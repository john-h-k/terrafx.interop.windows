// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B824B49D-22AC-4161-AC8A-9916E8FA3F7F")]
    public unsafe partial struct IInitializeWithStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInitializeWithStream*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInitializeWithStream*, uint>)(lpVtbl[1]))((IInitializeWithStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInitializeWithStream*, uint>)(lpVtbl[2]))((IInitializeWithStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IStream *")] IStream* pstream, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* stdcall<IInitializeWithStream*, IStream*, uint, int>)(lpVtbl[3]))((IInitializeWithStream*)Unsafe.AsPointer(ref this), pstream, grfMode);
        }
    }
}
