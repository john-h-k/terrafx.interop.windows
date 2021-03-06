// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BF87B6E0-8C27-11D0-B3F0-00AA003761C5")]
    public unsafe partial struct ICaptureGraphBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, Guid*, void**, int>)(lpVtbl[0]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, uint>)(lpVtbl[1]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, uint>)(lpVtbl[2]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFiltergraph([NativeTypeName("IGraphBuilder *")] IGraphBuilder* pfg)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, IGraphBuilder*, int>)(lpVtbl[3]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pfg);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiltergraph([NativeTypeName("IGraphBuilder **")] IGraphBuilder** ppfg)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, IGraphBuilder**, int>)(lpVtbl[4]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), ppfg);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputFileName([NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("LPCOLESTR")] ushort* lpstrFile, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppf, [NativeTypeName("IFileSinkFilter **")] IFileSinkFilter** ppSink)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, Guid*, ushort*, IBaseFilter**, IFileSinkFilter**, int>)(lpVtbl[5]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pType, lpstrFile, ppf, ppSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindInterface([NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("IBaseFilter *")] IBaseFilter* pf, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppint)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, Guid*, IBaseFilter*, Guid*, void**, int>)(lpVtbl[6]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pCategory, pf, riid, ppint);
        }

        [return: NativeTypeName("HRESULT")]
        public int RenderStream([NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("IUnknown *")] IUnknown* pSource, [NativeTypeName("IBaseFilter *")] IBaseFilter* pfCompressor, [NativeTypeName("IBaseFilter *")] IBaseFilter* pfRenderer)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, Guid*, IUnknown*, IBaseFilter*, IBaseFilter*, int>)(lpVtbl[7]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pCategory, pSource, pfCompressor, pfRenderer);
        }

        [return: NativeTypeName("HRESULT")]
        public int ControlStream([NativeTypeName("const GUID *")] Guid* pCategory, [NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("REFERENCE_TIME *")] long* pstart, [NativeTypeName("REFERENCE_TIME *")] long* pstop, [NativeTypeName("WORD")] ushort wStartCookie, [NativeTypeName("WORD")] ushort wStopCookie)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, Guid*, IBaseFilter*, long*, long*, ushort, ushort, int>)(lpVtbl[8]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pCategory, pFilter, pstart, pstop, wStartCookie, wStopCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int AllocCapFile([NativeTypeName("LPCOLESTR")] ushort* lpstr, [NativeTypeName("DWORDLONG")] ulong dwlSize)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, ushort*, ulong, int>)(lpVtbl[9]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), lpstr, dwlSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyCaptureFile([NativeTypeName("LPOLESTR")] ushort* lpwstrOld, [NativeTypeName("LPOLESTR")] ushort* lpwstrNew, int fAllowEscAbort, [NativeTypeName("IAMCopyCaptureFileProgress *")] IAMCopyCaptureFileProgress* pCallback)
        {
            return ((delegate* stdcall<ICaptureGraphBuilder*, ushort*, ushort*, int, IAMCopyCaptureFileProgress*, int>)(lpVtbl[10]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), lpwstrOld, lpwstrNew, fAllowEscAbort, pCallback);
        }
    }
}
