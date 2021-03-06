// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F88CFB8C-EF16-4991-B450-CB8C69E51704")]
    public unsafe partial struct IMFMetadata
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMetadata*, Guid*, void**, int>)(lpVtbl[0]))((IMFMetadata*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMetadata*, uint>)(lpVtbl[1]))((IMFMetadata*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMetadata*, uint>)(lpVtbl[2]))((IMFMetadata*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLanguage([NativeTypeName("LPCWSTR")] ushort* pwszRFC1766)
        {
            return ((delegate* stdcall<IMFMetadata*, ushort*, int>)(lpVtbl[3]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszRFC1766);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLanguage([NativeTypeName("LPWSTR *")] ushort** ppwszRFC1766)
        {
            return ((delegate* stdcall<IMFMetadata*, ushort**, int>)(lpVtbl[4]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppwszRFC1766);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllLanguages([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppvLanguages)
        {
            return ((delegate* stdcall<IMFMetadata*, PROPVARIANT*, int>)(lpVtbl[5]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppvLanguages);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppvValue)
        {
            return ((delegate* stdcall<IMFMetadata*, ushort*, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName, ppvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppvValue)
        {
            return ((delegate* stdcall<IMFMetadata*, ushort*, PROPVARIANT*, int>)(lpVtbl[7]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName, ppvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteProperty([NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* stdcall<IMFMetadata*, ushort*, int>)(lpVtbl[8]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllPropertyNames([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppvNames)
        {
            return ((delegate* stdcall<IMFMetadata*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppvNames);
        }
    }
}
