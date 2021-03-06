// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVIDER_FUNCTIONS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("PFN_CPD_MEM_ALLOC")]
        public delegate* stdcall<uint, void*> pfnAlloc;

        [NativeTypeName("PFN_CPD_MEM_FREE")]
        public delegate* stdcall<void*, void> pfnFree;

        [NativeTypeName("PFN_CPD_ADD_STORE")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, void*, int> pfnAddStore2Chain;

        [NativeTypeName("PFN_CPD_ADD_SGNR")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int, uint, CRYPT_PROVIDER_SGNR*, int> pfnAddSgnr2Chain;

        [NativeTypeName("PFN_CPD_ADD_CERT")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, uint, int, uint, CERT_CONTEXT*, int> pfnAddCert2Chain;

        [NativeTypeName("PFN_CPD_ADD_PRIVDATA")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, CRYPT_PROVIDER_PRIVDATA*, int> pfnAddPrivData2Chain;

        [NativeTypeName("PFN_PROVIDER_INIT_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnInitialize;

        [NativeTypeName("PFN_PROVIDER_OBJTRUST_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnObjectTrust;

        [NativeTypeName("PFN_PROVIDER_SIGTRUST_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnSignatureTrust;

        [NativeTypeName("PFN_PROVIDER_CERTTRUST_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnCertificateTrust;

        [NativeTypeName("PFN_PROVIDER_FINALPOLICY_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnFinalPolicy;

        [NativeTypeName("PFN_PROVIDER_CERTCHKPOLICY_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, uint, int, uint, int> pfnCertCheckPolicy;

        [NativeTypeName("PFN_PROVIDER_TESTFINALPOLICY_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnTestFinalPolicy;

        [NativeTypeName("struct _CRYPT_PROVUI_FUNCS *")]
        public CRYPT_PROVUI_FUNCS* psUIpfns;

        [NativeTypeName("PFN_PROVIDER_CLEANUP_CALL")]
        public delegate* stdcall<CRYPT_PROVIDER_DATA*, int> pfnCleanupPolicy;
    }
}
