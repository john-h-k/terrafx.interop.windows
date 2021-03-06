// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6C44DF74-72B9-4992-A1EC-EF996E0422D4")]
    public unsafe partial struct ISpVoice
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpVoice*, Guid*, void**, int>)(lpVtbl[0]))((ISpVoice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpVoice*, uint>)(lpVtbl[1]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpVoice*, uint>)(lpVtbl[2]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifySink([NativeTypeName("ISpNotifySink *")] ISpNotifySink* pNotifySink)
        {
            return ((delegate* stdcall<ISpVoice*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpVoice*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpVoice*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpVoice*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* stdcall<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpVoice*, delegate* stdcall<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpVoice*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackInterface([NativeTypeName("ISpNotifyCallback *")] ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpVoice*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpVoice*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWin32Event()
        {
            return ((delegate* stdcall<ISpVoice*, int>)(lpVtbl[7]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* stdcall<ISpVoice*, uint, int>)(lpVtbl[8]))((ISpVoice*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetNotifyEventHandle()
        {
            return ((delegate* stdcall<ISpVoice*, IntPtr>)(lpVtbl[9]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* stdcall<ISpVoice*, ulong, ulong, int>)(lpVtbl[10]))((ISpVoice*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvents([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* stdcall<ISpVoice*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpVoice*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("SPEVENTSOURCEINFO *")] SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* stdcall<ISpVoice*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpVoice*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutput([NativeTypeName("IUnknown *")] IUnknown* pUnkOutput, [NativeTypeName("BOOL")] int fAllowFormatChanges)
        {
            return ((delegate* stdcall<ISpVoice*, IUnknown*, int, int>)(lpVtbl[13]))((ISpVoice*)Unsafe.AsPointer(ref this), pUnkOutput, fAllowFormatChanges);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputObjectToken([NativeTypeName("ISpObjectToken **")] ISpObjectToken** ppObjectToken)
        {
            return ((delegate* stdcall<ISpVoice*, ISpObjectToken**, int>)(lpVtbl[14]))((ISpVoice*)Unsafe.AsPointer(ref this), ppObjectToken);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputStream([NativeTypeName("ISpStreamFormat **")] ISpStreamFormat** ppStream)
        {
            return ((delegate* stdcall<ISpVoice*, ISpStreamFormat**, int>)(lpVtbl[15]))((ISpVoice*)Unsafe.AsPointer(ref this), ppStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<ISpVoice*, int>)(lpVtbl[16]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* stdcall<ISpVoice*, int>)(lpVtbl[17]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVoice([NativeTypeName("ISpObjectToken *")] ISpObjectToken* pToken)
        {
            return ((delegate* stdcall<ISpVoice*, ISpObjectToken*, int>)(lpVtbl[18]))((ISpVoice*)Unsafe.AsPointer(ref this), pToken);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVoice([NativeTypeName("ISpObjectToken **")] ISpObjectToken** ppToken)
        {
            return ((delegate* stdcall<ISpVoice*, ISpObjectToken**, int>)(lpVtbl[19]))((ISpVoice*)Unsafe.AsPointer(ref this), ppToken);
        }

        [return: NativeTypeName("HRESULT")]
        public int Speak([NativeTypeName("LPCWSTR")] ushort* pwcs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* stdcall<ISpVoice*, ushort*, uint, uint*, int>)(lpVtbl[20]))((ISpVoice*)Unsafe.AsPointer(ref this), pwcs, dwFlags, pulStreamNumber);
        }

        [return: NativeTypeName("HRESULT")]
        public int SpeakStream([NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* stdcall<ISpVoice*, IStream*, uint, uint*, int>)(lpVtbl[21]))((ISpVoice*)Unsafe.AsPointer(ref this), pStream, dwFlags, pulStreamNumber);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("SPVOICESTATUS *")] SPVOICESTATUS* pStatus, [NativeTypeName("LPWSTR *")] ushort** ppszLastBookmark)
        {
            return ((delegate* stdcall<ISpVoice*, SPVOICESTATUS*, ushort**, int>)(lpVtbl[22]))((ISpVoice*)Unsafe.AsPointer(ref this), pStatus, ppszLastBookmark);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("LPCWSTR")] ushort* pItemType, [NativeTypeName("long")] int lNumItems, [NativeTypeName("ULONG *")] uint* pulNumSkipped)
        {
            return ((delegate* stdcall<ISpVoice*, ushort*, int, uint*, int>)(lpVtbl[23]))((ISpVoice*)Unsafe.AsPointer(ref this), pItemType, lNumItems, pulNumSkipped);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPriority(SPVPRIORITY ePriority)
        {
            return ((delegate* stdcall<ISpVoice*, SPVPRIORITY, int>)(lpVtbl[24]))((ISpVoice*)Unsafe.AsPointer(ref this), ePriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("SPVPRIORITY *")] SPVPRIORITY* pePriority)
        {
            return ((delegate* stdcall<ISpVoice*, SPVPRIORITY*, int>)(lpVtbl[25]))((ISpVoice*)Unsafe.AsPointer(ref this), pePriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlertBoundary(SPEVENTENUM eBoundary)
        {
            return ((delegate* stdcall<ISpVoice*, SPEVENTENUM, int>)(lpVtbl[26]))((ISpVoice*)Unsafe.AsPointer(ref this), eBoundary);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAlertBoundary([NativeTypeName("SPEVENTENUM *")] SPEVENTENUM* peBoundary)
        {
            return ((delegate* stdcall<ISpVoice*, SPEVENTENUM*, int>)(lpVtbl[27]))((ISpVoice*)Unsafe.AsPointer(ref this), peBoundary);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRate([NativeTypeName("long")] int RateAdjust)
        {
            return ((delegate* stdcall<ISpVoice*, int, int>)(lpVtbl[28]))((ISpVoice*)Unsafe.AsPointer(ref this), RateAdjust);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRate([NativeTypeName("long *")] int* pRateAdjust)
        {
            return ((delegate* stdcall<ISpVoice*, int*, int>)(lpVtbl[29]))((ISpVoice*)Unsafe.AsPointer(ref this), pRateAdjust);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume([NativeTypeName("USHORT")] ushort usVolume)
        {
            return ((delegate* stdcall<ISpVoice*, ushort, int>)(lpVtbl[30]))((ISpVoice*)Unsafe.AsPointer(ref this), usVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVolume([NativeTypeName("USHORT *")] ushort* pusVolume)
        {
            return ((delegate* stdcall<ISpVoice*, ushort*, int>)(lpVtbl[31]))((ISpVoice*)Unsafe.AsPointer(ref this), pusVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitUntilDone([NativeTypeName("ULONG")] uint msTimeout)
        {
            return ((delegate* stdcall<ISpVoice*, uint, int>)(lpVtbl[32]))((ISpVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSyncSpeakTimeout([NativeTypeName("ULONG")] uint msTimeout)
        {
            return ((delegate* stdcall<ISpVoice*, uint, int>)(lpVtbl[33]))((ISpVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSyncSpeakTimeout([NativeTypeName("ULONG *")] uint* pmsTimeout)
        {
            return ((delegate* stdcall<ISpVoice*, uint*, int>)(lpVtbl[34]))((ISpVoice*)Unsafe.AsPointer(ref this), pmsTimeout);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr SpeakCompleteEvent()
        {
            return ((delegate* stdcall<ISpVoice*, IntPtr>)(lpVtbl[35]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, [NativeTypeName("void *")] void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, [NativeTypeName("BOOL *")] int* pfSupported)
        {
            return ((delegate* stdcall<ISpVoice*, ushort*, void*, uint, int*, int>)(lpVtbl[36]))((ISpVoice*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, pfSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, [NativeTypeName("void *")] void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData)
        {
            return ((delegate* stdcall<ISpVoice*, IntPtr, ushort*, ushort*, void*, uint, int>)(lpVtbl[37]))((ISpVoice*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
        }
    }
}
