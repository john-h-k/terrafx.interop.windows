// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCB821A8-1039-441E-9F1C-B1759C2F3CEC")]
    public unsafe partial struct IDMLDispatchable
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDMLDispatchable*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDMLDispatchable*, uint>)(lpVtbl[1]))((IDMLDispatchable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDMLDispatchable*, uint>)(lpVtbl[2]))((IDMLDispatchable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return ((delegate* stdcall<IDMLDispatchable*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* stdcall<IDMLDispatchable*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return ((delegate* stdcall<IDMLDispatchable*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* stdcall<IDMLDispatchable*, ushort*, int>)(lpVtbl[6]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IDMLDispatchable*, Guid*, void**, int>)(lpVtbl[7]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public DML_BINDING_PROPERTIES GetBindingProperties()
        {
            DML_BINDING_PROPERTIES result;
            return *((delegate* stdcall<IDMLDispatchable*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*>)(lpVtbl[8]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
