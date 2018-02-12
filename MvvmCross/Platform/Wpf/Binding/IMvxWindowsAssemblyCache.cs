﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Reflection;

namespace MvvmCross.Platform.Wpf.Binding
{
    public interface IMvxWindowsAssemblyCache
    {
        IList<Assembly> Assemblies { get; }
    }
}
