// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CTRL_KEY_AGREE_DECRYPT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("_CMSG_CTRL_KEY_AGREE_DECRYPT_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:8089:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref nuint hCryptProv => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hCryptProv, 1));

        public ref nuint hNCryptKey => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hNCryptKey, 1));

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("PCMSG_KEY_AGREE_RECIPIENT_INFO")]
        public CMSG_KEY_AGREE_RECIPIENT_INFO* pKeyAgree;

        [NativeTypeName("DWORD")]
        public uint dwRecipientIndex;

        [NativeTypeName("DWORD")]
        public uint dwRecipientEncryptedKeyIndex;

        public CRYPT_BIT_BLOB OriginatorPublicKey;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HCRYPTPROV")]
            public nuint hCryptProv;

            [FieldOffset(0)]
            [NativeTypeName("NCRYPT_KEY_HANDLE")]
            public nuint hNCryptKey;
        }
    }
}
