// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Interface that enqueues download requests for remote fonts, characters, glyphs, and font fragments. Provides methods to asynchronously execute a download, cancel pending downloads, and be notified of download completion. Callbacks to listeners will occur on the downloading thread, and objects must be must be able to handle calls on their methods from other threads at any time.</summary>
    [Guid("B71E6052-5AEA-4FA3-832E-F60D431F7E91")]
    public unsafe partial struct IDWriteFontDownloadQueue
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontDownloadQueue* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontDownloadQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontDownloadQueue* This);

        /// <summary>Registers a client-defined listener object that receives download notifications. All registered listener's DownloadCompleted will be called after BeginDownload completes.</summary>
        /// <param name="listener">Listener object to add.</param>
        /// <param name="token">Receives a token value, which the caller must subsequently pass to RemoveListener.</param>
        /// <returns> Standard HRESULT error code.</returns>
        /// <remarks> An IDWriteFontDownloadListener can also be passed to BeginDownload via the context parameter, rather than globally registered to the queue.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddListener(IDWriteFontDownloadQueue* This, IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32")] uint* token);

        /// <summary>Unregisters a notification handler that was previously registered using AddListener.</summary>
        /// <param name="token">Token value previously returned by AddListener.</param>
        /// <returns> Returns S_OK if successful or E_INVALIDARG if the specified token does not correspond to a registered listener.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveListener(IDWriteFontDownloadQueue* This, [NativeTypeName("UINT32")] uint token);

        /// <summary>Determines whether the download queue is empty. Note that the queue does not include requests that are already being downloaded. In other words, BeginDownload clears the queue.</summary>
        /// <returns> TRUE if the queue is empty, FALSE if there are requests pending for BeginDownload.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsEmpty(IDWriteFontDownloadQueue* This);

        /// <summary>Begins an asynchronous download operation. The download operation executes in the background until it completes or is cancelled by a CancelDownload call.</summary>
        /// <param name="context">Optional context object that is passed back to the download notification handler's DownloadCompleted method. If the context object implements IDWriteFontDownloadListener, its DownloadCompleted will be called when done.</param>
        /// <returns> Returns S_OK if a download was successfully begun, S_FALSE if the queue was empty, or a standard HRESULT error code.</returns>
        /// <remarks> BeginDownload removes all download requests from the queue, transferring them to a background download operation. If any previous downloads are still ongoing when BeginDownload is called again, the new download does not complete until the previous downloads have finished. If the queue is empty and no active downloads are pending, the DownloadCompleted callback is called immediately with DWRITE_DOWNLOAD_RESULT_NONE.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginDownload(IDWriteFontDownloadQueue* This, IUnknown* context = null);

        /// <summary>Removes all download requests from the queue and cancels any active download operations. This calls DownloadCompleted with DWRITE_E_DOWNLOADCANCELLED. Applications should call this when shutting down if they started any downloads that have not finished yet with a call to DownloadCompleted.</summary>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CancelDownload(IDWriteFontDownloadQueue* This);

        /// <summary>Get the current generation number of the download queue, which is incremented every time after a download completes, whether failed or successful. This cookie comparison value may be used to compared against cached data to know when it is stale.</summary>
        /// <returns> The number of download queue generations.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetGenerationCount(IDWriteFontDownloadQueue* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddListener(IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32")] uint* token)
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddListener>(lpVtbl->AddListener)(This, listener, token);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveListener([NativeTypeName("UINT32")] uint token)
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveListener>(lpVtbl->RemoveListener)(This, token);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmpty()
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsEmpty>(lpVtbl->IsEmpty)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDownload(IUnknown* context = null)
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_BeginDownload>(lpVtbl->BeginDownload)(This, context);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelDownload()
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CancelDownload>(lpVtbl->CancelDownload)(This);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetGenerationCount()
        {
            fixed (IDWriteFontDownloadQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGenerationCount>(lpVtbl->GetGenerationCount)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AddListener;

            public IntPtr RemoveListener;

            public IntPtr IsEmpty;

            public IntPtr BeginDownload;

            public IntPtr CancelDownload;

            public IntPtr GetGenerationCount;
        }
    }
}