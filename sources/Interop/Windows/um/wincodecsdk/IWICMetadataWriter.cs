// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F7836E16-3BE0-470B-86BB-160D0AECD7DE")]
    public unsafe partial struct IWICMetadataWriter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICMetadataWriter*, uint>)(lpVtbl[1]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICMetadataWriter*, uint>)(lpVtbl[2]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo([NativeTypeName("IWICMetadataHandlerInfo **")] IWICMetadataHandlerInfo** ppIHandler)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)(lpVtbl[4]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, uint*, int>)(lpVtbl[5]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[6]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[7]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)(lpVtbl[8]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[9]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[10]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[11]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValueByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return ((delegate* stdcall<IWICMetadataWriter*, uint, int>)(lpVtbl[12]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex);
        }
    }
}
