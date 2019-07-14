// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    public unsafe struct IWICJpegFrameDecode
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICJpegFrameDecode* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICJpegFrameDecode* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportIndexing(
            [In] IWICJpegFrameDecode* This,
            [Out, NativeTypeName("BOOL")] int* pfIndexingSupported
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetIndexing(
            [In] IWICJpegFrameDecode* This,
            [In] WICJpegIndexingOptions options,
            [In, NativeTypeName("UINT")] uint horizontalIntervalSize
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ClearIndexing(
            [In] IWICJpegFrameDecode* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAcHuffmanTable(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDcHuffmanTable(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetQuantizationTable(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFrameHeader(
            [In] IWICJpegFrameDecode* This,
            [Out] WICJpegFrameHeader* pFrameHeader
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetScanHeader(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [Out] WICJpegScanHeader* pScanHeader
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyScan(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint scanOffset,
            [In, NativeTypeName("UINT")] uint cbScanData,
            [Out, NativeTypeName("BYTE[]")] byte* pbScanData,
            [Out, NativeTypeName("UINT")] uint* pcbScanDataActual
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyMinimalStream(
            [In] IWICJpegFrameDecode* This,
            [In, NativeTypeName("UINT")] uint streamOffset,
            [In, NativeTypeName("UINT")] uint cbStreamData,
            [Out, NativeTypeName("BYTE[]")] byte* pbStreamData,
            [Out, NativeTypeName("UINT")] uint* pcbStreamDataActual
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportIndexing(
            [Out, NativeTypeName("BOOL")] int* pfIndexingSupported
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_DoesSupportIndexing>(lpVtbl->DoesSupportIndexing)(
                    This,
                    pfIndexingSupported
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIndexing(
            [In] WICJpegIndexingOptions options,
            [In, NativeTypeName("UINT")] uint horizontalIntervalSize
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_SetIndexing>(lpVtbl->SetIndexing)(
                    This,
                    options,
                    horizontalIntervalSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearIndexing()
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_ClearIndexing>(lpVtbl->ClearIndexing)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_GetAcHuffmanTable>(lpVtbl->GetAcHuffmanTable)(
                    This,
                    scanIndex,
                    tableIndex,
                    pAcHuffmanTable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_GetDcHuffmanTable>(lpVtbl->GetDcHuffmanTable)(
                    This,
                    scanIndex,
                    tableIndex,
                    pDcHuffmanTable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint tableIndex,
            [Out] DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_GetQuantizationTable>(lpVtbl->GetQuantizationTable)(
                    This,
                    scanIndex,
                    tableIndex,
                    pQuantizationTable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameHeader(
            [Out] WICJpegFrameHeader* pFrameHeader
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_GetFrameHeader>(lpVtbl->GetFrameHeader)(
                    This,
                    pFrameHeader
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScanHeader(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [Out] WICJpegScanHeader* pScanHeader
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_GetScanHeader>(lpVtbl->GetScanHeader)(
                    This,
                    scanIndex,
                    pScanHeader
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyScan(
            [In, NativeTypeName("UINT")] uint scanIndex,
            [In, NativeTypeName("UINT")] uint scanOffset,
            [In, NativeTypeName("UINT")] uint cbScanData,
            [Out, NativeTypeName("BYTE[]")] byte* pbScanData,
            [Out, NativeTypeName("UINT")] uint* pcbScanDataActual
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_CopyScan>(lpVtbl->CopyScan)(
                    This,
                    scanIndex,
                    scanOffset,
                    cbScanData,
                    pbScanData,
                    pcbScanDataActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyMinimalStream(
            [In, NativeTypeName("UINT")] uint streamOffset,
            [In, NativeTypeName("UINT")] uint cbStreamData,
            [Out, NativeTypeName("BYTE[]")] byte* pbStreamData,
            [Out, NativeTypeName("UINT")] uint* pcbStreamDataActual
        )
        {
            fixed (IWICJpegFrameDecode* This = &this)
            {
                return MarshalFunction<_CopyMinimalStream>(lpVtbl->CopyMinimalStream)(
                    This,
                    streamOffset,
                    cbStreamData,
                    pbStreamData,
                    pcbStreamDataActual
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr DoesSupportIndexing;

            public IntPtr SetIndexing;

            public IntPtr ClearIndexing;

            public IntPtr GetAcHuffmanTable;

            public IntPtr GetDcHuffmanTable;

            public IntPtr GetQuantizationTable;

            public IntPtr GetFrameHeader;

            public IntPtr GetScanHeader;

            public IntPtr CopyScan;

            public IntPtr CopyMinimalStream;
            #endregion
        }
        #endregion
    }
}