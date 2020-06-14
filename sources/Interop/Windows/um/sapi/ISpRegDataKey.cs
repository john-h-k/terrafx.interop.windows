// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92A66E2B-C830-4149-83DF-6FC2BA1E7A5B")]
    public unsafe partial struct ISpRegDataKey
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpRegDataKey*, Guid*, void**, int>)(lpVtbl[0]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpRegDataKey*, uint>)(lpVtbl[1]))((ISpRegDataKey*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpRegDataKey*, uint>)(lpVtbl[2]))((ISpRegDataKey*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pData)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, uint, int>)(lpVtbl[7]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, uint*, int>)(lpVtbl[8]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("ISpDataKey **")] ISpDataKey** ppSubKey)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, int>)(lpVtbl[11]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszSubKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
        {
            return ((delegate* stdcall<ISpRegDataKey*, ushort*, int>)(lpVtbl[12]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), pszValueName);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
        {
            return ((delegate* stdcall<ISpRegDataKey*, uint, ushort**, int>)(lpVtbl[13]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
        {
            return ((delegate* stdcall<ISpRegDataKey*, uint, ushort**, int>)(lpVtbl[14]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), Index, ppszValueName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetKey([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("BOOL")] int fReadOnly)
        {
            return ((delegate* stdcall<ISpRegDataKey*, IntPtr, int, int>)(lpVtbl[15]))((ISpRegDataKey*)Unsafe.AsPointer(ref this), hkey, fReadOnly);
        }
    }
}
