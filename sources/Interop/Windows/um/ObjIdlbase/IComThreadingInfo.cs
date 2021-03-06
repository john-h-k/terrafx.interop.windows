// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CE-0000-0000-C000-000000000046")]
    public unsafe partial struct IComThreadingInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IComThreadingInfo*, Guid*, void**, int>)(lpVtbl[0]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IComThreadingInfo*, uint>)(lpVtbl[1]))((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IComThreadingInfo*, uint>)(lpVtbl[2]))((IComThreadingInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentApartmentType([NativeTypeName("APTTYPE *")] APTTYPE* pAptType)
        {
            return ((delegate* stdcall<IComThreadingInfo*, APTTYPE*, int>)(lpVtbl[3]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pAptType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentThreadType([NativeTypeName("THDTYPE *")] THDTYPE* pThreadType)
        {
            return ((delegate* stdcall<IComThreadingInfo*, THDTYPE*, int>)(lpVtbl[4]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pThreadType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguidLogicalThreadId)
        {
            return ((delegate* stdcall<IComThreadingInfo*, Guid*, int>)(lpVtbl[5]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pguidLogicalThreadId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* stdcall<IComThreadingInfo*, Guid*, int>)(lpVtbl[6]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), rguid);
        }
    }
}
