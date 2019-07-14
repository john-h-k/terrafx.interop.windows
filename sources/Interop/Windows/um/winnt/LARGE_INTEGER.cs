// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winnt.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER
    {
        #region Fields
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public _u_e__Struct u;

        [FieldOffset(0)]
        [NativeTypeName("LONGLONG")]
        public long QuadPart;
        #endregion

        #region Structs
        public struct _Anonymous_e__Struct
        {
            #region Fields
            [NativeTypeName("DWORD")]
            public uint LowPart;

            [NativeTypeName("LONG")]
            public int HighPart;
            #endregion
        }

        public struct _u_e__Struct
        {
            #region Fields
            [NativeTypeName("DWORD")]
            public uint LowPart;

            [NativeTypeName("LONG")]
            public int HighPart;
            #endregion
        }
        #endregion
    }
}