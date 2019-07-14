// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Tile effect's top level properties.</summary>
    public enum D2D1_TILE_PROP : uint
    {
        /// <summary>Property Name: "Rect" Property Type: D2D1_VECTOR_4F</summary>
        D2D1_TILE_PROP_RECT = 0,

        D2D1_TILE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}