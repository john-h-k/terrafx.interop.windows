// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DFCD8E4D-30B5-4567-ACAA-8EB5B7853DC9")]
    public unsafe partial struct IMFQualityAdviseLimits
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFQualityAdviseLimits*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFQualityAdviseLimits*, uint>)(lpVtbl[1]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFQualityAdviseLimits*, uint>)(lpVtbl[2]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaximumDropMode([NativeTypeName("MF_QUALITY_DROP_MODE *")] MF_QUALITY_DROP_MODE* peDropMode)
        {
            return ((delegate* stdcall<IMFQualityAdviseLimits*, MF_QUALITY_DROP_MODE*, int>)(lpVtbl[3]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), peDropMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMinimumQualityLevel([NativeTypeName("MF_QUALITY_LEVEL *")] MF_QUALITY_LEVEL* peQualityLevel)
        {
            return ((delegate* stdcall<IMFQualityAdviseLimits*, MF_QUALITY_LEVEL*, int>)(lpVtbl[4]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), peQualityLevel);
        }
    }
}
