// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000122-0000-0000-C000-000000000046")]
    public unsafe partial struct IDropTarget
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDropTarget*, Guid*, void**, int>)(lpVtbl[0]))((IDropTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDropTarget*, uint>)(lpVtbl[1]))((IDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDropTarget*, uint>)(lpVtbl[2]))((IDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DragEnter([NativeTypeName("IDataObject *")] IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* stdcall<IDropTarget*, IDataObject*, uint, POINTL, uint*, int>)(lpVtbl[3]))((IDropTarget*)Unsafe.AsPointer(ref this), pDataObj, grfKeyState, pt, pdwEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DragOver([NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* stdcall<IDropTarget*, uint, POINTL, uint*, int>)(lpVtbl[4]))((IDropTarget*)Unsafe.AsPointer(ref this), grfKeyState, pt, pdwEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int DragLeave()
        {
            return ((delegate* stdcall<IDropTarget*, int>)(lpVtbl[5]))((IDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Drop([NativeTypeName("IDataObject *")] IDataObject* pDataObj, [NativeTypeName("DWORD")] uint grfKeyState, POINTL pt, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* stdcall<IDropTarget*, IDataObject*, uint, POINTL, uint*, int>)(lpVtbl[6]))((IDropTarget*)Unsafe.AsPointer(ref this), pDataObj, grfKeyState, pt, pdwEffect);
        }
    }
}
