// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("913C24A0-20AB-11D2-9038-00A0C9697298")]
    public unsafe partial struct IDDrawExclModeVideoCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDDrawExclModeVideoCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDDrawExclModeVideoCallback*, uint>)(lpVtbl[1]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDDrawExclModeVideoCallback*, uint>)(lpVtbl[2]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUpdateOverlay([NativeTypeName("BOOL")] int bBefore, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int bOldVisible, [NativeTypeName("const RECT *")] RECT* prcOldSrc, [NativeTypeName("const RECT *")] RECT* prcOldDest, [NativeTypeName("BOOL")] int bNewVisible, [NativeTypeName("const RECT *")] RECT* prcNewSrc, [NativeTypeName("const RECT *")] RECT* prcNewDest)
        {
            return ((delegate* stdcall<IDDrawExclModeVideoCallback*, int, uint, int, RECT*, RECT*, int, RECT*, RECT*, int>)(lpVtbl[3]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), bBefore, dwFlags, bOldVisible, prcOldSrc, prcOldDest, bNewVisible, prcNewSrc, prcNewDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUpdateColorKey([NativeTypeName("const COLORKEY *")] COLORKEY* pKey, [NativeTypeName("DWORD")] uint dwColor)
        {
            return ((delegate* stdcall<IDDrawExclModeVideoCallback*, COLORKEY*, uint, int>)(lpVtbl[4]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), pKey, dwColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnUpdateSize([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwARWidth, [NativeTypeName("DWORD")] uint dwARHeight)
        {
            return ((delegate* stdcall<IDDrawExclModeVideoCallback*, uint, uint, uint, uint, int>)(lpVtbl[5]))((IDDrawExclModeVideoCallback*)Unsafe.AsPointer(ref this), dwWidth, dwHeight, dwARWidth, dwARHeight);
        }
    }
}
