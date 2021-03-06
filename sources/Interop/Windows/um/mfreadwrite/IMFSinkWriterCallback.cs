// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("666F76DE-33D2-41B9-A458-29ED0A972C58")]
    public unsafe partial struct IMFSinkWriterCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSinkWriterCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSinkWriterCallback*, uint>)(lpVtbl[1]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSinkWriterCallback*, uint>)(lpVtbl[2]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFinalize([NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* stdcall<IMFSinkWriterCallback*, int, int>)(lpVtbl[3]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
        {
            return ((delegate* stdcall<IMFSinkWriterCallback*, uint, void*, int>)(lpVtbl[4]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
        }
    }
}
