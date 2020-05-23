// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CERT_STORE_PROV_FIND_CERT([NativeTypeName("HCERTSTOREPROV")] void* hStoreProv, [NativeTypeName("PCCERT_STORE_PROV_FIND_INFO")] CERT_STORE_PROV_FIND_INFO* pFindInfo, [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("void **")] void** ppvStoreProvFindInfo, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppProvCertContext);
}