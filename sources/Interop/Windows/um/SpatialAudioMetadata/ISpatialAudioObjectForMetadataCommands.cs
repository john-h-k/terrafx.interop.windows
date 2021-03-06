// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0DF2C94B-F5F9-472D-AF6B-C46E0AC9CD05")]
    public unsafe partial struct ISpatialAudioObjectForMetadataCommands
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), frameCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsActive([NativeTypeName("BOOL *")] int* isActive)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, int*, int>)(lpVtbl[5]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), isActive);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioObjectType([NativeTypeName("AudioObjectType *")] AudioObjectType* audioObjectType)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), audioObjectType);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteNextMetadataCommand([NativeTypeName("BYTE")] byte commandID, [NativeTypeName("void *")] void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength)
        {
            return ((delegate* stdcall<ISpatialAudioObjectForMetadataCommands*, byte, void*, uint, int>)(lpVtbl[7]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), commandID, valueBuffer, valueBufferLength);
        }
    }
}
