// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED90C8AD-5C34-4D05-A1EC-0E8A9B3AD7AF")]
    public unsafe partial struct IPrintDocumentPackageStatusEvent
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, uint>)(lpVtbl[1]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, uint>)(lpVtbl[2]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, uint*, int>)(lpVtbl[3]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int PackageStatusUpdated([NativeTypeName("PrintDocumentPackageStatus *")] PrintDocumentPackageStatus* packageStatus)
        {
            return ((delegate* stdcall<IPrintDocumentPackageStatusEvent*, PrintDocumentPackageStatus*, int>)(lpVtbl[7]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), packageStatus);
        }
    }
}
