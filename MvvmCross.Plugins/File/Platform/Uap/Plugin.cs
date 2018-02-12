﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.


using MvvmCross.Plugins;

namespace MvvmCross.Plugin.File.Platform.Uap
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<IMvxFileStore, MvxWindowsFileStore>();
            Mvx.RegisterType<IMvxFileStoreAsync, MvxWindowsFileStore>();
        }
    }
}
