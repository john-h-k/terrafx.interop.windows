// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9E5-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetProtocolSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetProtocolSink*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetProtocolSink*, uint>)(lpVtbl[1]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetProtocolSink*, uint>)(lpVtbl[2]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Switch([NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* stdcall<IInternetProtocolSink*, PROTOCOLDATA*, int>)(lpVtbl[3]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return ((delegate* stdcall<IInternetProtocolSink*, uint, ushort*, int>)(lpVtbl[4]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), ulStatusCode, szStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax)
        {
            return ((delegate* stdcall<IInternetProtocolSink*, uint, uint, uint, int>)(lpVtbl[5]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), grfBSCF, ulProgress, ulProgressMax);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportResult([NativeTypeName("HRESULT")] int hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] ushort* szResult)
        {
            return ((delegate* stdcall<IInternetProtocolSink*, int, uint, ushort*, int>)(lpVtbl[6]))((IInternetProtocolSink*)Unsafe.AsPointer(ref this), hrResult, dwError, szResult);
        }
    }
}
