// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4995F511-9DDB-4F12-BD3B-F04611807B79")]
    public unsafe partial struct IAMGraphBuilderCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMGraphBuilderCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMGraphBuilderCallback*, uint>)(lpVtbl[1]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMGraphBuilderCallback*, uint>)(lpVtbl[2]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SelectedFilter([NativeTypeName("IMoniker *")] IMoniker* pMon)
        {
            return ((delegate* stdcall<IAMGraphBuilderCallback*, IMoniker*, int>)(lpVtbl[3]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), pMon);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatedFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFil)
        {
            return ((delegate* stdcall<IAMGraphBuilderCallback*, IBaseFilter*, int>)(lpVtbl[4]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), pFil);
        }
    }
}
