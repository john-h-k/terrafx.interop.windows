// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct STARTUPINFOA
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("LPSTR")]
        public sbyte* lpReserved;

        [NativeTypeName("LPSTR")]
        public sbyte* lpDesktop;

        [NativeTypeName("LPSTR")]
        public sbyte* lpTitle;

        [NativeTypeName("DWORD")]
        public uint dwX;

        [NativeTypeName("DWORD")]
        public uint dwY;

        [NativeTypeName("DWORD")]
        public uint dwXSize;

        [NativeTypeName("DWORD")]
        public uint dwYSize;

        [NativeTypeName("DWORD")]
        public uint dwXCountChars;

        [NativeTypeName("DWORD")]
        public uint dwYCountChars;

        [NativeTypeName("DWORD")]
        public uint dwFillAttribute;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("WORD")]
        public ushort wShowWindow;

        [NativeTypeName("WORD")]
        public ushort cbReserved2;

        [NativeTypeName("LPBYTE")]
        public byte* lpReserved2;

        [NativeTypeName("HANDLE")]
        public IntPtr hStdInput;

        [NativeTypeName("HANDLE")]
        public IntPtr hStdOutput;

        [NativeTypeName("HANDLE")]
        public IntPtr hStdError;
    }
}
