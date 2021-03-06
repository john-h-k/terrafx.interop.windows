// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TXFS_LIST_TRANSACTION_LOCKED_FILES
    {
        [NativeTypeName("GUID")]
        public Guid KtmTransaction;

        [NativeTypeName("DWORDLONG")]
        public ulong NumberOfFiles;

        [NativeTypeName("DWORDLONG")]
        public ulong BufferSizeRequired;

        [NativeTypeName("DWORDLONG")]
        public ulong Offset;
    }
}
