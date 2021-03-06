// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("66E11784-F695-4F28-A505-A7080081A78F")]
    public unsafe partial struct IAudioEndpointVolumeEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint>)(lpVtbl[1]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint>)(lpVtbl[2]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterControlChangeNotify([NativeTypeName("IAudioEndpointVolumeCallback *")] IAudioEndpointVolumeCallback* pNotify)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, IAudioEndpointVolumeCallback*, int>)(lpVtbl[3]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pNotify);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterControlChangeNotify([NativeTypeName("IAudioEndpointVolumeCallback *")] IAudioEndpointVolumeCallback* pNotify)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, IAudioEndpointVolumeCallback*, int>)(lpVtbl[4]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pNotify);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* pnChannelCount)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint*, int>)(lpVtbl[5]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pnChannelCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMasterVolumeLevel(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, float, Guid*, int>)(lpVtbl[6]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMasterVolumeLevelScalar(float fLevel, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, float, Guid*, int>)(lpVtbl[7]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), fLevel, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMasterVolumeLevel([NativeTypeName("float *")] float* pfLevelDB)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, float*, int>)(lpVtbl[8]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pfLevelDB);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMasterVolumeLevelScalar([NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, float*, int>)(lpVtbl[9]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pfLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumeLevel([NativeTypeName("UINT")] uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint, float, Guid*, int>)(lpVtbl[10]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumeLevelScalar([NativeTypeName("UINT")] uint nChannel, float fLevel, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint, float, Guid*, int>)(lpVtbl[11]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, fLevel, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolumeLevel([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfLevelDB)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint, float*, int>)(lpVtbl[12]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelVolumeLevelScalar([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint, float*, int>)(lpVtbl[13]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), nChannel, pfLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMute([NativeTypeName("BOOL")] int bMute, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, int, Guid*, int>)(lpVtbl[14]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), bMute, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMute([NativeTypeName("BOOL *")] int* pbMute)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, int*, int>)(lpVtbl[15]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pbMute);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVolumeStepInfo([NativeTypeName("UINT *")] uint* pnStep, [NativeTypeName("UINT *")] uint* pnStepCount)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint*, uint*, int>)(lpVtbl[16]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pnStep, pnStepCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int VolumeStepUp([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, Guid*, int>)(lpVtbl[17]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int VolumeStepDown([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, Guid*, int>)(lpVtbl[18]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint*, int>)(lpVtbl[19]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pdwHardwareSupportMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVolumeRange([NativeTypeName("float *")] float* pflVolumeMindB, [NativeTypeName("float *")] float* pflVolumeMaxdB, [NativeTypeName("float *")] float* pflVolumeIncrementdB)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, float*, float*, float*, int>)(lpVtbl[20]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), pflVolumeMindB, pflVolumeMaxdB, pflVolumeIncrementdB);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVolumeRangeChannel([NativeTypeName("UINT")] uint iChannel, [NativeTypeName("float *")] float* pflVolumeMindB, [NativeTypeName("float *")] float* pflVolumeMaxdB, [NativeTypeName("float *")] float* pflVolumeIncrementdB)
        {
            return ((delegate* stdcall<IAudioEndpointVolumeEx*, uint, float*, float*, float*, int>)(lpVtbl[21]))((IAudioEndpointVolumeEx*)Unsafe.AsPointer(ref this), iChannel, pflVolumeMindB, pflVolumeMaxdB, pflVolumeIncrementdB);
        }
    }
}
