// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6E13380-30AC-11D0-A18C-00A0C9118956")]
    public unsafe partial struct IAMCrossbar
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMCrossbar*, Guid*, void**, int>)(lpVtbl[0]))((IAMCrossbar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMCrossbar*, uint>)(lpVtbl[1]))((IAMCrossbar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMCrossbar*, uint>)(lpVtbl[2]))((IAMCrossbar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_PinCounts([NativeTypeName("long *")] int* OutputPinCount, [NativeTypeName("long *")] int* InputPinCount)
        {
            return ((delegate* stdcall<IAMCrossbar*, int*, int*, int>)(lpVtbl[3]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinCount, InputPinCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int CanRoute([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long")] int InputPinIndex)
        {
            return ((delegate* stdcall<IAMCrossbar*, int, int, int>)(lpVtbl[4]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinIndex, InputPinIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int Route([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long")] int InputPinIndex)
        {
            return ((delegate* stdcall<IAMCrossbar*, int, int, int>)(lpVtbl[5]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinIndex, InputPinIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_IsRoutedTo([NativeTypeName("long")] int OutputPinIndex, [NativeTypeName("long *")] int* InputPinIndex)
        {
            return ((delegate* stdcall<IAMCrossbar*, int, int*, int>)(lpVtbl[6]))((IAMCrossbar*)Unsafe.AsPointer(ref this), OutputPinIndex, InputPinIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CrossbarPinInfo([NativeTypeName("BOOL")] int IsInputPin, [NativeTypeName("long")] int PinIndex, [NativeTypeName("long *")] int* PinIndexRelated, [NativeTypeName("long *")] int* PhysicalType)
        {
            return ((delegate* stdcall<IAMCrossbar*, int, int, int*, int*, int>)(lpVtbl[7]))((IAMCrossbar*)Unsafe.AsPointer(ref this), IsInputPin, PinIndex, PinIndexRelated, PhysicalType);
        }
    }
}
