// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("133ADCD4-19B4-4020-9FDC-842E78253B17")]
    public unsafe partial struct ISpPhoneticAlphabetConverter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, uint>)(lpVtbl[1]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, uint>)(lpVtbl[2]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLangId([NativeTypeName("WORD *")] ushort* pLangID)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, ushort*, int>)(lpVtbl[3]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this), pLangID);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLangId([NativeTypeName("WORD")] ushort LangID)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, ushort, int>)(lpVtbl[4]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this), LangID);
        }

        [return: NativeTypeName("HRESULT")]
        public int SAPI2UPS([NativeTypeName("const SPPHONEID *")] ushort* pszSAPIId, [NativeTypeName("SPPHONEID *")] ushort* pszUPSId, [NativeTypeName("DWORD")] uint cMaxLength)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, ushort*, ushort*, uint, int>)(lpVtbl[5]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this), pszSAPIId, pszUPSId, cMaxLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int UPS2SAPI([NativeTypeName("const SPPHONEID *")] ushort* pszUPSId, [NativeTypeName("SPPHONEID *")] ushort* pszSAPIId, [NativeTypeName("DWORD")] uint cMaxLength)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, ushort*, ushort*, uint, int>)(lpVtbl[6]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this), pszUPSId, pszSAPIId, cMaxLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxConvertLength([NativeTypeName("DWORD")] uint cSrcLength, [NativeTypeName("BOOL")] int bSAPI2UPS, [NativeTypeName("DWORD *")] uint* pcMaxDestLength)
        {
            return ((delegate* stdcall<ISpPhoneticAlphabetConverter*, uint, int, uint*, int>)(lpVtbl[7]))((ISpPhoneticAlphabetConverter*)Unsafe.AsPointer(ref this), cSrcLength, bSAPI2UPS, pcMaxDestLength);
        }
    }
}
