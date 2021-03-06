// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F52E2B61-18A1-11D1-B105-00805F49916B")]
    public unsafe partial struct IXMLDocument
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDocument*, uint>)(lpVtbl[1]))((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDocument*, uint>)(lpVtbl[2]))((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDocument*, uint*, int>)(lpVtbl[3]))((IXMLDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDocument*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDocument*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_root([NativeTypeName("IXMLElement **")] IXMLElement** p)
        {
            return ((delegate* stdcall<IXMLDocument*, IXMLElement**, int>)(lpVtbl[7]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[8]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[9]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[10]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[11]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort*, int>)(lpVtbl[12]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[13]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* stdcall<IXMLDocument*, int*, int>)(lpVtbl[14]))((IXMLDocument*)Unsafe.AsPointer(ref this), pl);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[15]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] ushort* p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort*, int>)(lpVtbl[16]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[17]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[18]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* stdcall<IXMLDocument*, ushort**, int>)(lpVtbl[19]))((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int createElement(VARIANT vType, VARIANT var1, [NativeTypeName("IXMLElement **")] IXMLElement** ppElem)
        {
            return ((delegate* stdcall<IXMLDocument*, VARIANT, VARIANT, IXMLElement**, int>)(lpVtbl[20]))((IXMLDocument*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }
    }
}
