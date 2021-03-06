// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000112-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleObject
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleObject*, uint>)(lpVtbl[1]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleObject*, uint>)(lpVtbl[2]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClientSite([NativeTypeName("IOleClientSite *")] IOleClientSite* pClientSite)
        {
            return ((delegate* stdcall<IOleObject*, IOleClientSite*, int>)(lpVtbl[3]))((IOleObject*)Unsafe.AsPointer(ref this), pClientSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClientSite([NativeTypeName("IOleClientSite **")] IOleClientSite** ppClientSite)
        {
            return ((delegate* stdcall<IOleObject*, IOleClientSite**, int>)(lpVtbl[4]))((IOleObject*)Unsafe.AsPointer(ref this), ppClientSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHostNames([NativeTypeName("LPCOLESTR")] ushort* szContainerApp, [NativeTypeName("LPCOLESTR")] ushort* szContainerObj)
        {
            return ((delegate* stdcall<IOleObject*, ushort*, ushort*, int>)(lpVtbl[5]))((IOleObject*)Unsafe.AsPointer(ref this), szContainerApp, szContainerObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("DWORD")] uint dwSaveOption)
        {
            return ((delegate* stdcall<IOleObject*, uint, int>)(lpVtbl[6]))((IOleObject*)Unsafe.AsPointer(ref this), dwSaveOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return ((delegate* stdcall<IOleObject*, uint, IMoniker*, int>)(lpVtbl[7]))((IOleObject*)Unsafe.AsPointer(ref this), dwWhichMoniker, pmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return ((delegate* stdcall<IOleObject*, uint, uint, IMoniker**, int>)(lpVtbl[8]))((IOleObject*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitFromData([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("BOOL")] int fCreation, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IOleObject*, IDataObject*, int, uint, int>)(lpVtbl[9]))((IOleObject*)Unsafe.AsPointer(ref this), pDataObject, fCreation, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipboardData([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IDataObject **")] IDataObject** ppDataObject)
        {
            return ((delegate* stdcall<IOleObject*, uint, IDataObject**, int>)(lpVtbl[10]))((IOleObject*)Unsafe.AsPointer(ref this), dwReserved, ppDataObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoVerb([NativeTypeName("LONG")] int iVerb, [NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("IOleClientSite *")] IOleClientSite* pActiveSite, [NativeTypeName("LONG")] int lindex, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* stdcall<IOleObject*, int, MSG*, IOleClientSite*, int, IntPtr, RECT*, int>)(lpVtbl[11]))((IOleObject*)Unsafe.AsPointer(ref this), iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumVerbs([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppEnumOleVerb)
        {
            return ((delegate* stdcall<IOleObject*, IEnumOLEVERB**, int>)(lpVtbl[12]))((IOleObject*)Unsafe.AsPointer(ref this), ppEnumOleVerb);
        }

        [return: NativeTypeName("HRESULT")]
        public int Update()
        {
            return ((delegate* stdcall<IOleObject*, int>)(lpVtbl[13]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUpToDate()
        {
            return ((delegate* stdcall<IOleObject*, int>)(lpVtbl[14]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return ((delegate* stdcall<IOleObject*, Guid*, int>)(lpVtbl[15]))((IOleObject*)Unsafe.AsPointer(ref this), pClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserType([NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] ushort** pszUserType)
        {
            return ((delegate* stdcall<IOleObject*, uint, ushort**, int>)(lpVtbl[16]))((IOleObject*)Unsafe.AsPointer(ref this), dwFormOfType, pszUserType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return ((delegate* stdcall<IOleObject*, uint, SIZE*, int>)(lpVtbl[17]))((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return ((delegate* stdcall<IOleObject*, uint, SIZE*, int>)(lpVtbl[18]))((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* stdcall<IOleObject*, IAdviseSink*, uint*, int>)(lpVtbl[19]))((IOleObject*)Unsafe.AsPointer(ref this), pAdvSink, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* stdcall<IOleObject*, uint, int>)(lpVtbl[20]))((IOleObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* stdcall<IOleObject*, IEnumSTATDATA**, int>)(lpVtbl[21]))((IOleObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMiscStatus([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* stdcall<IOleObject*, uint, uint*, int>)(lpVtbl[22]))((IOleObject*)Unsafe.AsPointer(ref this), dwAspect, pdwStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorScheme([NativeTypeName("LOGPALETTE *")] LOGPALETTE* pLogpal)
        {
            return ((delegate* stdcall<IOleObject*, LOGPALETTE*, int>)(lpVtbl[23]))((IOleObject*)Unsafe.AsPointer(ref this), pLogpal);
        }
    }
}
