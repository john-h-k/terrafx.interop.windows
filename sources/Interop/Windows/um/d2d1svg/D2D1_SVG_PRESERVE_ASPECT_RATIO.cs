// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_SVG_PRESERVE_ASPECT_RATIO
    {
        [NativeTypeName("BOOL")]
        public int defer;

        public D2D1_SVG_ASPECT_ALIGN align;

        public D2D1_SVG_ASPECT_SCALING meetOrSlice;
    }
}
