﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

namespace MvvmCross.ViewModels.Hints
{
    public class MvxClosePresentationHint
        : MvxPresentationHint
    {
        public MvxClosePresentationHint(IMvxViewModel viewModelToClose)
        {
            ViewModelToClose = viewModelToClose;
        }

        public IMvxViewModel ViewModelToClose { get; private set; }
    }
}
