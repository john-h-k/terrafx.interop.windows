// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("39DC7F4A-B141-4719-813C-A7F46162A2B8")]
    public unsafe partial struct IMFSensorProcessActivity
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, uint>)(lpVtbl[1]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, uint>)(lpVtbl[2]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProcessId([NativeTypeName("ULONG *")] uint* pPID)
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, uint*, int>)(lpVtbl[3]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pPID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamingState([NativeTypeName("BOOL *")] int* pfStreaming)
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, int*, int>)(lpVtbl[4]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pfStreaming);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamingMode([NativeTypeName("MFSensorDeviceMode *")] MFSensorDeviceMode* pMode)
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, MFSensorDeviceMode*, int>)(lpVtbl[5]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReportTime([NativeTypeName("FILETIME *")] FILETIME* pft)
        {
            return ((delegate* stdcall<IMFSensorProcessActivity*, FILETIME*, int>)(lpVtbl[6]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pft);
        }
    }
}
