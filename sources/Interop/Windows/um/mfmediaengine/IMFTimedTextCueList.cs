// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD128745-211B-40A0-9981-FE65F166D0FD")]
    public unsafe partial struct IMFTimedTextCueList
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, uint>)(lpVtbl[1]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, uint>)(lpVtbl[2]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, uint>)(lpVtbl[3]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCueByIndex([NativeTypeName("DWORD")] uint index, [NativeTypeName("IMFTimedTextCue **")] IMFTimedTextCue** cue)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)(lpVtbl[4]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), index, cue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCueById([NativeTypeName("DWORD")] uint id, [NativeTypeName("IMFTimedTextCue **")] IMFTimedTextCue** cue)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)(lpVtbl[5]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), id, cue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCueByOriginalId([NativeTypeName("LPCWSTR")] ushort* originalId, [NativeTypeName("IMFTimedTextCue **")] IMFTimedTextCue** cue)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, ushort*, IMFTimedTextCue**, int>)(lpVtbl[6]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), originalId, cue);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddTextCue(double start, double duration, [NativeTypeName("LPCWSTR")] ushort* text, [NativeTypeName("IMFTimedTextCue **")] IMFTimedTextCue** cue)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, double, double, ushort*, IMFTimedTextCue**, int>)(lpVtbl[7]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), start, duration, text, cue);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddDataCue(double start, double duration, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("DWORD")] uint dataSize, [NativeTypeName("IMFTimedTextCue **")] IMFTimedTextCue** cue)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)(lpVtbl[8]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), start, duration, data, dataSize, cue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveCue([NativeTypeName("IMFTimedTextCue *")] IMFTimedTextCue* cue)
        {
            return ((delegate* stdcall<IMFTimedTextCueList*, IMFTimedTextCue*, int>)(lpVtbl[9]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), cue);
        }
    }
}
