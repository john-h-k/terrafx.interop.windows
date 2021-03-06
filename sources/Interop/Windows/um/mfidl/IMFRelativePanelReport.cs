// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F25362EA-2C0E-447F-81E2-755914CDC0C3")]
    public unsafe partial struct IMFRelativePanelReport
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFRelativePanelReport*, Guid*, void**, int>)(lpVtbl[0]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFRelativePanelReport*, uint>)(lpVtbl[1]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFRelativePanelReport*, uint>)(lpVtbl[2]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRelativePanel([NativeTypeName("ULONG *")] uint* panel)
        {
            return ((delegate* stdcall<IMFRelativePanelReport*, uint*, int>)(lpVtbl[3]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this), panel);
        }
    }
}
