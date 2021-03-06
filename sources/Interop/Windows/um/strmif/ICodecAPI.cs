// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("901DB4C7-31CE-41A2-85DC-8FA0BF41B8DA")]
    public unsafe partial struct ICodecAPI
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, void**, int>)(lpVtbl[0]))((ICodecAPI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICodecAPI*, uint>)(lpVtbl[1]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICodecAPI*, uint>)(lpVtbl[2]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, int>)(lpVtbl[3]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsModifiable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, int>)(lpVtbl[4]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* ValueMin, [NativeTypeName("VARIANT *")] VARIANT* ValueMax, [NativeTypeName("VARIANT *")] VARIANT* SteppingDelta)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT **")] VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[7]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[8]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, VARIANT*, int>)(lpVtbl[9]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterForEvent([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("LONG_PTR")] nint userData)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, nint, int>)(lpVtbl[10]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, userData);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterForEvent([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, int>)(lpVtbl[11]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAllDefaults()
        {
            return ((delegate* stdcall<ICodecAPI*, int>)(lpVtbl[12]))((ICodecAPI*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueWithNotify([NativeTypeName("const GUID *")] Guid* Api, [NativeTypeName("VARIANT *")] VARIANT* Value, [NativeTypeName("GUID **")] Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid*, VARIANT*, Guid**, uint*, int>)(lpVtbl[13]))((ICodecAPI*)Unsafe.AsPointer(ref this), Api, Value, ChangedParam, ChangedParamCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAllDefaultsWithNotify([NativeTypeName("GUID **")] Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* stdcall<ICodecAPI*, Guid**, uint*, int>)(lpVtbl[14]))((ICodecAPI*)Unsafe.AsPointer(ref this), ChangedParam, ChangedParamCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllSettings([NativeTypeName("IStream *")] IStream* __MIDL__ICodecAPI0000)
        {
            return ((delegate* stdcall<ICodecAPI*, IStream*, int>)(lpVtbl[15]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0000);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAllSettings([NativeTypeName("IStream *")] IStream* __MIDL__ICodecAPI0001)
        {
            return ((delegate* stdcall<ICodecAPI*, IStream*, int>)(lpVtbl[16]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0001);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAllSettingsWithNotify([NativeTypeName("IStream *")] IStream* __MIDL__ICodecAPI0002, [NativeTypeName("GUID **")] Guid** ChangedParam, [NativeTypeName("ULONG *")] uint* ChangedParamCount)
        {
            return ((delegate* stdcall<ICodecAPI*, IStream*, Guid**, uint*, int>)(lpVtbl[17]))((ICodecAPI*)Unsafe.AsPointer(ref this), __MIDL__ICodecAPI0002, ChangedParam, ChangedParamCount);
        }
    }
}
