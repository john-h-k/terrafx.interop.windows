// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE2DE0E4-5BCA-4F2D-AA46-5D13F8FDB3A9")]
    public unsafe partial struct IPart
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPart*, Guid*, void**, int>)(lpVtbl[0]))((IPart*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPart*, uint>)(lpVtbl[1]))((IPart*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPart*, uint>)(lpVtbl[2]))((IPart*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName)
        {
            return ((delegate* stdcall<IPart*, ushort**, int>)(lpVtbl[3]))((IPart*)Unsafe.AsPointer(ref this), ppwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocalId([NativeTypeName("UINT *")] uint* pnId)
        {
            return ((delegate* stdcall<IPart*, uint*, int>)(lpVtbl[4]))((IPart*)Unsafe.AsPointer(ref this), pnId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlobalId([NativeTypeName("LPWSTR *")] ushort** ppwstrGlobalId)
        {
            return ((delegate* stdcall<IPart*, ushort**, int>)(lpVtbl[5]))((IPart*)Unsafe.AsPointer(ref this), ppwstrGlobalId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartType([NativeTypeName("PartType *")] PartType* pPartType)
        {
            return ((delegate* stdcall<IPart*, PartType*, int>)(lpVtbl[6]))((IPart*)Unsafe.AsPointer(ref this), pPartType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubType([NativeTypeName("GUID *")] Guid* pSubType)
        {
            return ((delegate* stdcall<IPart*, Guid*, int>)(lpVtbl[7]))((IPart*)Unsafe.AsPointer(ref this), pSubType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetControlInterfaceCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* stdcall<IPart*, uint*, int>)(lpVtbl[8]))((IPart*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetControlInterface([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IControlInterface **")] IControlInterface** ppInterfaceDesc)
        {
            return ((delegate* stdcall<IPart*, uint, IControlInterface**, int>)(lpVtbl[9]))((IPart*)Unsafe.AsPointer(ref this), nIndex, ppInterfaceDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumPartsIncoming([NativeTypeName("IPartsList **")] IPartsList** ppParts)
        {
            return ((delegate* stdcall<IPart*, IPartsList**, int>)(lpVtbl[10]))((IPart*)Unsafe.AsPointer(ref this), ppParts);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumPartsOutgoing([NativeTypeName("IPartsList **")] IPartsList** ppParts)
        {
            return ((delegate* stdcall<IPart*, IPartsList**, int>)(lpVtbl[11]))((IPart*)Unsafe.AsPointer(ref this), ppParts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTopologyObject([NativeTypeName("IDeviceTopology **")] IDeviceTopology** ppTopology)
        {
            return ((delegate* stdcall<IPart*, IDeviceTopology**, int>)(lpVtbl[12]))((IPart*)Unsafe.AsPointer(ref this), ppTopology);
        }

        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* refiid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPart*, uint, Guid*, void**, int>)(lpVtbl[13]))((IPart*)Unsafe.AsPointer(ref this), dwClsContext, refiid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterControlChangeCallback([NativeTypeName("const GUID &")] Guid* riid, [NativeTypeName("IControlChangeNotify *")] IControlChangeNotify* pNotify)
        {
            return ((delegate* stdcall<IPart*, Guid*, IControlChangeNotify*, int>)(lpVtbl[14]))((IPart*)Unsafe.AsPointer(ref this), riid, pNotify);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterControlChangeCallback([NativeTypeName("IControlChangeNotify *")] IControlChangeNotify* pNotify)
        {
            return ((delegate* stdcall<IPart*, IControlChangeNotify*, int>)(lpVtbl[15]))((IPart*)Unsafe.AsPointer(ref this), pNotify);
        }
    }
}
