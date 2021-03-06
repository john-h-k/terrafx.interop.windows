// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDEA49FF-3BC0-4377-8AAD-9FBCFD808566")]
    public unsafe partial struct ISpatialAudioObjectForMetadataItems
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), frameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsActive([NativeTypeName("BOOL *")] int* isActive)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, int*, int>)(lpVtbl[5]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), isActive);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioObjectType([NativeTypeName("AudioObjectType *")] AudioObjectType* audioObjectType)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), audioObjectType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpatialAudioMetadataItems([NativeTypeName("ISpatialAudioMetadataItems **")] ISpatialAudioMetadataItems** metadataItems)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataItems*, ISpatialAudioMetadataItems**, int>)(lpVtbl[7]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), metadataItems);
        }
    }
}
