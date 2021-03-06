// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BCD7C78F-3098-4F22-B547-A2F25A381269")]
    public unsafe partial struct ISpatialAudioMetadataItems
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameCount([NativeTypeName("UINT16 *")] ushort* frameCount)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[3]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), frameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemCount([NativeTypeName("UINT16 *")] ushort* itemCount)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), itemCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxItemCount([NativeTypeName("UINT16 *")] ushort* maxItemCount)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[5]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), maxItemCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxValueBufferLength([NativeTypeName("UINT32 *")] uint* maxValueBufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, uint*, int>)(lpVtbl[6]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), maxValueBufferLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("SpatialAudioMetadataItemsInfo *")] SpatialAudioMetadataItemsInfo* info)
        {
            return ((delegate* stdcall<ISpatialAudioMetadataItems*, SpatialAudioMetadataItemsInfo*, int>)(lpVtbl[7]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), info);
        }
    }
}
