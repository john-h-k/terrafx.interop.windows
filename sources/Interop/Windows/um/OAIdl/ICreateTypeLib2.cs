// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002040F-0000-0000-C000-000000000046")]
    public unsafe partial struct ICreateTypeLib2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICreateTypeLib2*, uint>)(lpVtbl[1]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICreateTypeLib2*, uint>)(lpVtbl[2]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, [NativeTypeName("ICreateTypeInfo **")] ICreateTypeInfo** ppCTInfo)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort*, TYPEKIND, ICreateTypeInfo**, int>)(lpVtbl[3]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort*, int>)(lpVtbl[4]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort, ushort, int>)(lpVtbl[5]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, Guid*, int>)(lpVtbl[6]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort*, int>)(lpVtbl[7]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort*, int>)(lpVtbl[8]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szHelpFileName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, uint, int>)(lpVtbl[9]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLcid([NativeTypeName("LCID")] uint lcid)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, uint, int>)(lpVtbl[10]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), lcid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLibFlags([NativeTypeName("UINT")] uint uLibFlags)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, uint, int>)(lpVtbl[11]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), uLibFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAllChanges()
        {
            return ((delegate* stdcall<ICreateTypeLib2*, int>)(lpVtbl[12]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort*, int>)(lpVtbl[13]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, Guid*, VARIANT*, int>)(lpVtbl[14]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, uint, int>)(lpVtbl[15]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringDll([NativeTypeName("LPOLESTR")] ushort* szFileName)
        {
            return ((delegate* stdcall<ICreateTypeLib2*, ushort*, int>)(lpVtbl[16]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szFileName);
        }
    }
}
