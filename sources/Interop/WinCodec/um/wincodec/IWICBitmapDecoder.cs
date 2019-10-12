// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
    public unsafe partial struct IWICBitmapDecoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapDecoder* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapDecoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapDecoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryCapability(IWICBitmapDecoder* This, [Optional] IStream* pIStream, [NativeTypeName("DWORD")] uint* pdwCapability);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Initialize(IWICBitmapDecoder* This, [Optional] IStream* pIStream, WICDecodeOptions cacheOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICBitmapDecoder* This, [NativeTypeName("GUID")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDecoderInfo(IWICBitmapDecoder* This, IWICBitmapDecoderInfo** ppIDecoderInfo = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPalette(IWICBitmapDecoder* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryReader(IWICBitmapDecoder* This, IWICMetadataQueryReader** ppIMetadataQueryReader = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPreview(IWICBitmapDecoder* This, IWICBitmapSource** ppIBitmapSource = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorContexts(IWICBitmapDecoder* This, [NativeTypeName("UINT")] uint cCount, [Optional, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT")] uint* pcActualCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetThumbnail(IWICBitmapDecoder* This, IWICBitmapSource** ppIThumbnail = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameCount(IWICBitmapDecoder* This, [NativeTypeName("UINT")] uint* pCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrame(IWICBitmapDecoder* This, [NativeTypeName("UINT")] uint index, IWICBitmapFrameDecode** ppIBitmapFrame = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryCapability([Optional] IStream* pIStream, [NativeTypeName("DWORD")] uint* pdwCapability)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryCapability>(lpVtbl->QueryCapability)(This, pIStream, pdwCapability);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([Optional] IStream* pIStream, WICDecodeOptions cacheOptions)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(This, pIStream, cacheOptions);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID")] Guid* pguidContainerFormat)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(This, pguidContainerFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo = null)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDecoderInfo>(lpVtbl->GetDecoderInfo)(This, ppIDecoderInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader = null)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryReader>(lpVtbl->GetMetadataQueryReader)(This, ppIMetadataQueryReader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreview(IWICBitmapSource** ppIBitmapSource = null)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPreview>(lpVtbl->GetPreview)(This, ppIBitmapSource);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [Optional, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT")] uint* pcActualCount)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorContexts>(lpVtbl->GetColorContexts)(This, cCount, ppIColorContexts, pcActualCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IWICBitmapSource** ppIThumbnail = null)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetThumbnail>(lpVtbl->GetThumbnail)(This, ppIThumbnail);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameCount([NativeTypeName("UINT")] uint* pCount)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameCount>(lpVtbl->GetFrameCount)(This, pCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrame([NativeTypeName("UINT")] uint index, IWICBitmapFrameDecode** ppIBitmapFrame = null)
        {
            fixed (IWICBitmapDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrame>(lpVtbl->GetFrame)(This, index, ppIBitmapFrame);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr QueryCapability;

            public IntPtr Initialize;

            public IntPtr GetContainerFormat;

            public IntPtr GetDecoderInfo;

            public IntPtr CopyPalette;

            public IntPtr GetMetadataQueryReader;

            public IntPtr GetPreview;

            public IntPtr GetColorContexts;

            public IntPtr GetThumbnail;

            public IntPtr GetFrameCount;

            public IntPtr GetFrame;
        }
    }
}