// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CTRL_KEY_TRANS_DECRYPT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("_CMSG_CTRL_KEY_TRANS_DECRYPT_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wincrypt.h:8044:5)")]
        public _Anonymous_e__Union _Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        [NativeTypeName("PCMSG_KEY_TRANS_RECIPIENT_INFO")]
        public CMSG_KEY_TRANS_RECIPIENT_INFO* pKeyTrans;

        [NativeTypeName("DWORD")]
        public uint dwRecipientIndex;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HCRYPTPROV")]
            public UIntPtr hCryptProv;

            [FieldOffset(0)]
            [NativeTypeName("NCRYPT_KEY_HANDLE")]
            public UIntPtr hNCryptKey;
        }
    }
}
