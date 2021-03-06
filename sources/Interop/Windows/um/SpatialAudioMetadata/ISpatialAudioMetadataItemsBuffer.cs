// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("42640A16-E1BD-42D9-9FF6-031AB71A2DBA")]
    public unsafe partial struct ISpatialAudioMetadataItemsBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItemsBuffer*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItemsBuffer*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItemsBuffer*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AttachToBuffer([NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItemsBuffer*, byte*, uint, int>)(lpVtbl[3]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int AttachToPopulatedBuffer([NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItemsBuffer*, byte*, uint, int>)(lpVtbl[4]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int DetachBuffer()
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItemsBuffer*, int>)(lpVtbl[5]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}
