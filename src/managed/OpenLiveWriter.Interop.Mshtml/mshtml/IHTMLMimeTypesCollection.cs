// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

namespace mshtml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3050F3FC-98B5-11CF-BB82-00AA00BDCE0B"), TypeLibType((short) 0x1040)]
    public interface IHTMLMimeTypesCollection
    {
        [DispId(1)]
        int length { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get; }
    }
}

