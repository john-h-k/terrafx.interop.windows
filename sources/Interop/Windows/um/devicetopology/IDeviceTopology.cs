// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A07407E-6497-4A18-9787-32F79BD0D98F")]
    public unsafe partial struct IDeviceTopology
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDeviceTopology*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDeviceTopology*, uint>)(lpVtbl[1]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDeviceTopology*, uint>)(lpVtbl[2]))((IDeviceTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectorCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* stdcall<IDeviceTopology*, uint*, int>)(lpVtbl[3]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnector([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IConnector **")] IConnector** ppConnector)
        {
            return ((delegate* stdcall<IDeviceTopology*, uint, IConnector**, int>)(lpVtbl[4]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppConnector);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubunitCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* stdcall<IDeviceTopology*, uint*, int>)(lpVtbl[5]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubunit([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("ISubunit **")] ISubunit** ppSubunit)
        {
            return ((delegate* stdcall<IDeviceTopology*, uint, ISubunit**, int>)(lpVtbl[6]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nIndex, ppSubunit);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartById([NativeTypeName("UINT")] uint nId, [NativeTypeName("IPart **")] IPart** ppPart)
        {
            return ((delegate* stdcall<IDeviceTopology*, uint, IPart**, int>)(lpVtbl[7]))((IDeviceTopology*)Unsafe.AsPointer(ref this), nId, ppPart);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceId([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
        {
            return ((delegate* stdcall<IDeviceTopology*, ushort**, int>)(lpVtbl[8]))((IDeviceTopology*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSignalPath([NativeTypeName("IPart *")] IPart* pIPartFrom, [NativeTypeName("IPart *")] IPart* pIPartTo, [NativeTypeName("BOOL")] int bRejectMixedPaths, [NativeTypeName("IPartsList **")] IPartsList** ppParts)
        {
            return ((delegate* stdcall<IDeviceTopology*, IPart*, IPart*, int, IPartsList**, int>)(lpVtbl[9]))((IDeviceTopology*)Unsafe.AsPointer(ref this), pIPartFrom, pIPartTo, bRejectMixedPaths, ppParts);
        }
    }
}
