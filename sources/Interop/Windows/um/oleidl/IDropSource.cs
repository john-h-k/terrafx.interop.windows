// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000121-0000-0000-C000-000000000046")]
    public unsafe partial struct IDropSource
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDropSource*, Guid*, void**, int>)(lpVtbl[0]))((IDropSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDropSource*, uint>)(lpVtbl[1]))((IDropSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDropSource*, uint>)(lpVtbl[2]))((IDropSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryContinueDrag([NativeTypeName("BOOL")] int fEscapePressed, [NativeTypeName("DWORD")] uint grfKeyState)
        {
            return ((delegate* stdcall<IDropSource*, int, uint, int>)(lpVtbl[3]))((IDropSource*)Unsafe.AsPointer(ref this), fEscapePressed, grfKeyState);
        }

        [return: NativeTypeName("HRESULT")]
        public int GiveFeedback([NativeTypeName("DWORD")] uint dwEffect)
        {
            return ((delegate* stdcall<IDropSource*, uint, int>)(lpVtbl[4]))((IDropSource*)Unsafe.AsPointer(ref this), dwEffect);
        }
    }
}
