// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define FADF_AUTO ( 0x1 )")]
        public const int FADF_AUTO = (0x1);

        [NativeTypeName("#define FADF_STATIC ( 0x2 )")]
        public const int FADF_STATIC = (0x2);

        [NativeTypeName("#define FADF_EMBEDDED ( 0x4 )")]
        public const int FADF_EMBEDDED = (0x4);

        [NativeTypeName("#define FADF_FIXEDSIZE ( 0x10 )")]
        public const int FADF_FIXEDSIZE = (0x10);

        [NativeTypeName("#define FADF_RECORD ( 0x20 )")]
        public const int FADF_RECORD = (0x20);

        [NativeTypeName("#define FADF_HAVEIID ( 0x40 )")]
        public const int FADF_HAVEIID = (0x40);

        [NativeTypeName("#define FADF_HAVEVARTYPE ( 0x80 )")]
        public const int FADF_HAVEVARTYPE = (0x80);

        [NativeTypeName("#define FADF_BSTR ( 0x100 )")]
        public const int FADF_BSTR = (0x100);

        [NativeTypeName("#define FADF_UNKNOWN ( 0x200 )")]
        public const int FADF_UNKNOWN = (0x200);

        [NativeTypeName("#define FADF_DISPATCH ( 0x400 )")]
        public const int FADF_DISPATCH = (0x400);

        [NativeTypeName("#define FADF_VARIANT ( 0x800 )")]
        public const int FADF_VARIANT = (0x800);

        [NativeTypeName("#define FADF_RESERVED ( 0xf008 )")]
        public const int FADF_RESERVED = (0xf008);

        [NativeTypeName("#define PARAMFLAG_NONE ( 0 )")]
        public const int PARAMFLAG_NONE = (0);

        [NativeTypeName("#define PARAMFLAG_FIN ( 0x1 )")]
        public const int PARAMFLAG_FIN = (0x1);

        [NativeTypeName("#define PARAMFLAG_FOUT ( 0x2 )")]
        public const int PARAMFLAG_FOUT = (0x2);

        [NativeTypeName("#define PARAMFLAG_FLCID ( 0x4 )")]
        public const int PARAMFLAG_FLCID = (0x4);

        [NativeTypeName("#define PARAMFLAG_FRETVAL ( 0x8 )")]
        public const int PARAMFLAG_FRETVAL = (0x8);

        [NativeTypeName("#define PARAMFLAG_FOPT ( 0x10 )")]
        public const int PARAMFLAG_FOPT = (0x10);

        [NativeTypeName("#define PARAMFLAG_FHASDEFAULT ( 0x20 )")]
        public const int PARAMFLAG_FHASDEFAULT = (0x20);

        [NativeTypeName("#define PARAMFLAG_FHASCUSTDATA ( 0x40 )")]
        public const int PARAMFLAG_FHASCUSTDATA = (0x40);

        [NativeTypeName("#define IDLFLAG_NONE ( PARAMFLAG_NONE )")]
        public const int IDLFLAG_NONE = ((0));

        [NativeTypeName("#define IDLFLAG_FIN ( PARAMFLAG_FIN )")]
        public const int IDLFLAG_FIN = ((0x1));

        [NativeTypeName("#define IDLFLAG_FOUT ( PARAMFLAG_FOUT )")]
        public const int IDLFLAG_FOUT = ((0x2));

        [NativeTypeName("#define IDLFLAG_FLCID ( PARAMFLAG_FLCID )")]
        public const int IDLFLAG_FLCID = ((0x4));

        [NativeTypeName("#define IDLFLAG_FRETVAL ( PARAMFLAG_FRETVAL )")]
        public const int IDLFLAG_FRETVAL = ((0x8));

        [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULT ( 0x1 )")]
        public const int IMPLTYPEFLAG_FDEFAULT = (0x1);

        [NativeTypeName("#define IMPLTYPEFLAG_FSOURCE ( 0x2 )")]
        public const int IMPLTYPEFLAG_FSOURCE = (0x2);

        [NativeTypeName("#define IMPLTYPEFLAG_FRESTRICTED ( 0x4 )")]
        public const int IMPLTYPEFLAG_FRESTRICTED = (0x4);

        [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULTVTABLE ( 0x8 )")]
        public const int IMPLTYPEFLAG_FDEFAULTVTABLE = (0x8);

        [NativeTypeName("#define DISPID_UNKNOWN ( -1 )")]
        public const int DISPID_UNKNOWN = (-1);

        [NativeTypeName("#define DISPID_VALUE ( 0 )")]
        public const int DISPID_VALUE = (0);

        [NativeTypeName("#define DISPID_PROPERTYPUT ( -3 )")]
        public const int DISPID_PROPERTYPUT = (-3);

        [NativeTypeName("#define DISPID_NEWENUM ( -4 )")]
        public const int DISPID_NEWENUM = (-4);

        [NativeTypeName("#define DISPID_EVALUATE ( -5 )")]
        public const int DISPID_EVALUATE = (-5);

        [NativeTypeName("#define DISPID_CONSTRUCTOR ( -6 )")]
        public const int DISPID_CONSTRUCTOR = (-6);

        [NativeTypeName("#define DISPID_DESTRUCTOR ( -7 )")]
        public const int DISPID_DESTRUCTOR = (-7);

        [NativeTypeName("#define DISPID_COLLECT ( -8 )")]
        public const int DISPID_COLLECT = (-8);
    }
}
