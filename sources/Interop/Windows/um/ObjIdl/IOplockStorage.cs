// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D19C834-8879-11D1-83E9-00C04FC2C6D4")]
    public unsafe partial struct IOplockStorage
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOplockStorage*, Guid*, void**, int>)(lpVtbl[0]))((IOplockStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOplockStorage*, uint>)(lpVtbl[1]))((IOplockStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOplockStorage*, uint>)(lpVtbl[2]))((IOplockStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppstgOpen)
        {
            return ((delegate* stdcall<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int>)(lpVtbl[3]))((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppstgOpen)
        {
            return ((delegate* stdcall<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int>)(lpVtbl[4]))((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
        }
    }
}
