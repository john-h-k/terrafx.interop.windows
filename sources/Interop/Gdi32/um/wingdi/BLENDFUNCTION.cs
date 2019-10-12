// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct BLENDFUNCTION
    {
        [NativeTypeName("BYTE")]
        public byte BlendOp;

        [NativeTypeName("BYTE")]
        public byte BlendFlags;

        [NativeTypeName("BYTE")]
        public byte SourceConstantAlpha;

        [NativeTypeName("BYTE")]
        public byte AlphaFormat;
    }
}