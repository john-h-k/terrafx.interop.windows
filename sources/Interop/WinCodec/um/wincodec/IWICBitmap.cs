// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmap
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmap* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmap* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmap* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IWICBitmap* This, [NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormat(IWICBitmap* This, [NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResolution(IWICBitmap* This, double* pDpiX, double* pDpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPalette(IWICBitmap* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICBitmap* This, [Optional] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Lock(IWICBitmap* This, [Optional] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPalette(IWICBitmap* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResolution(IWICBitmap* This, double dpiX, double dpiY);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, puiWidth, puiHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, pPixelFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)(This, pDpiX, pDpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([Optional] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(This, prc, cbStride, cbBufferSize, pbBuffer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([Optional] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock = null)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Lock>(lpVtbl->Lock)(This, prcLock, flags, ppILock);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPalette>(lpVtbl->SetPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            fixed (IWICBitmap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResolution>(lpVtbl->SetResolution)(This, dpiX, dpiY);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetResolution;

            public IntPtr CopyPalette;

            public IntPtr CopyPixels;

            public IntPtr Lock;

            public IntPtr SetPalette;

            public IntPtr SetResolution;
        }
    }
}