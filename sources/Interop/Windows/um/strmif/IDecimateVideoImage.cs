// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2E5EA3E0-E924-11D2-B6DA-00A0C995E8DF")]
    public unsafe partial struct IDecimateVideoImage
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDecimateVideoImage*, Guid*, void**, int>)(lpVtbl[0]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDecimateVideoImage*, uint>)(lpVtbl[1]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDecimateVideoImage*, uint>)(lpVtbl[2]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDecimationImageSize([NativeTypeName("long")] int lWidth, [NativeTypeName("long")] int lHeight)
        {
            return ((delegate* stdcall<IDecimateVideoImage*, int, int, int>)(lpVtbl[3]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this), lWidth, lHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResetDecimationImageSize()
        {
            return ((delegate* stdcall<IDecimateVideoImage*, int>)(lpVtbl[4]))((IDecimateVideoImage*)Unsafe.AsPointer(ref this));
        }
    }
}
