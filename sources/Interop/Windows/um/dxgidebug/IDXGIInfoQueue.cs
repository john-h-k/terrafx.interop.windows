// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D67441C7-672A-476F-9E82-CD55B44949CE")]
    public unsafe partial struct IDXGIInfoQueue
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, uint>)(lpVtbl[1]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, uint>)(lpVtbl[2]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong, int>)(lpVtbl[3]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageCountLimit);
        }

        public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* stdcall<IDXGIInfoQueue*, Guid, void>)(lpVtbl[4]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE *")] DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong, DXGI_INFO_QUEUE_MESSAGE*, nuint*, int>)(lpVtbl[5]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageIndex, pMessage, pMessageByteLength);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[6]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[7]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[8]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[9]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[10]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[11]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[12]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[13]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        public void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* stdcall<IDXGIInfoQueue*, Guid, void>)(lpVtbl[14]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[15]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[16]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[17]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[18]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* stdcall<IDXGIInfoQueue*, Guid, void>)(lpVtbl[19]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, uint>)(lpVtbl[20]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[21]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[22]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* stdcall<IDXGIInfoQueue*, Guid, void>)(lpVtbl[23]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[24]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[25]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[26]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int>)(lpVtbl[27]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            ((delegate* stdcall<IDXGIInfoQueue*, Guid, void>)(lpVtbl[28]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, uint>)(lpVtbl[29]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, sbyte*, int>)(lpVtbl[30]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, Severity, ID, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int>)(lpVtbl[31]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int, int>)(lpVtbl[32]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, int>)(lpVtbl[33]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int, int, int>)(lpVtbl[34]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID, bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int>)(lpVtbl[35]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int>)(lpVtbl[36]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int, int>)(lpVtbl[37]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID);
        }

        public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("BOOL")] int bMute)
        {
            ((delegate* stdcall<IDXGIInfoQueue*, Guid, int, void>)(lpVtbl[38]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, bMute);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return ((delegate* stdcall<IDXGIInfoQueue*, Guid, int>)(lpVtbl[39]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }
    }
}
