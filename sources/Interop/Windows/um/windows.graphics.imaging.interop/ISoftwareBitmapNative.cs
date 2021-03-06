// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94BC8415-04EA-4B2E-AF13-4DE95AA898EB")]
    public unsafe partial struct ISoftwareBitmapNative
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, Guid*, void**, int>)(lpVtbl[0]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, uint>)(lpVtbl[1]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, uint>)(lpVtbl[2]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, uint*, Guid**, int>)(lpVtbl[3]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, IntPtr*, int>)(lpVtbl[4]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, TrustLevel*, int>)(lpVtbl[5]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<ISoftwareBitmapNative*, Guid*, void**, int>)(lpVtbl[6]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
