// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D3CE1BF-2367-40E0-9EEE-40D377CC1B46")]
    public unsafe partial struct IMFMediaSharingEngine
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, uint>)(lpVtbl[1]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, uint>)(lpVtbl[2]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetError([NativeTypeName("IMFMediaError **")] IMFMediaError** ppError)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppError);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), error);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceElements([NativeTypeName("IMFMediaEngineSrcElements *")] IMFMediaEngineSrcElements* pSrcElements)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pSrcElements);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("BSTR")] ushort* pUrl)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, ushort*, int>)(lpVtbl[6]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pUrl);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, ushort**, int>)(lpVtbl[7]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppUrl);
        }

        [return: NativeTypeName("USHORT")]
        public ushort GetNetworkState()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, ushort>)(lpVtbl[8]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        public MF_MEDIA_ENGINE_PRELOAD GetPreload()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, MF_MEDIA_ENGINE_PRELOAD>)(lpVtbl[9]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Preload);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffered([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [return: NativeTypeName("HRESULT")]
        public int Load()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[12]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("MF_MEDIA_ENGINE_CANPLAY *")] MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), type, pAnswer);
        }

        [return: NativeTypeName("USHORT")]
        public ushort GetReadyState()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, ushort>)(lpVtbl[14]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSeeking()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[15]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        public double GetCurrentTime()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double>)(lpVtbl[16]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTime(double seekTime)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double, int>)(lpVtbl[17]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), seekTime);
        }

        public double GetStartTime()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double>)(lpVtbl[18]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        public double GetDuration()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double>)(lpVtbl[19]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsPaused()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[20]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        public double GetDefaultPlaybackRate()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double>)(lpVtbl[21]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefaultPlaybackRate(double Rate)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double, int>)(lpVtbl[22]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Rate);
        }

        public double GetPlaybackRate()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double>)(lpVtbl[23]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPlaybackRate(double Rate)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double, int>)(lpVtbl[24]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Rate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPlayed([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppPlayed)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppPlayed);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSeekable([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppSeekable)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, IMFMediaTimeRange**, int>)(lpVtbl[26]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppSeekable);
        }

        [return: NativeTypeName("BOOL")]
        public int IsEnded()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[27]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetAutoPlay()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[28]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAutoPlay([NativeTypeName("BOOL")] int AutoPlay)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int, int>)(lpVtbl[29]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), AutoPlay);
        }

        [return: NativeTypeName("BOOL")]
        public int GetLoop()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[30]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLoop([NativeTypeName("BOOL")] int Loop)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int, int>)(lpVtbl[31]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Loop);
        }

        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[32]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[33]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuted()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[34]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMuted([NativeTypeName("BOOL")] int Muted)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int, int>)(lpVtbl[35]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Muted);
        }

        public double GetVolume()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double>)(lpVtbl[36]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume(double Volume)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, double, int>)(lpVtbl[37]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Volume);
        }

        [return: NativeTypeName("BOOL")]
        public int HasVideo()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[38]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int HasAudio()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[39]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, int>)(lpVtbl[42]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TransferVideoFrame([NativeTypeName("IUnknown *")] IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, long*, int>)(lpVtbl[44]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pPts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("DEVICE_INFO *")] DEVICE_INFO* pDevice)
        {
            return ((delegate* stdcall<IMFMediaSharingEngine*, DEVICE_INFO*, int>)(lpVtbl[45]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pDevice);
        }
    }
}
