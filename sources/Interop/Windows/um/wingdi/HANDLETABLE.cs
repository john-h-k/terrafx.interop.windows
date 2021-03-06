// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct HANDLETABLE
    {
        [NativeTypeName("HGDIOBJ [1]")]
        public _objectHandle_e__FixedBuffer objectHandle;

        public partial struct _objectHandle_e__FixedBuffer
        {
            public IntPtr e0;

            public ref IntPtr this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<IntPtr> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
