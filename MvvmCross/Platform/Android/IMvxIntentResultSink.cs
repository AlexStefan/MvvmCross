﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using MvvmCross.Platform.Android.Views.Base;

namespace MvvmCross.Platform.Android
{
    public interface IMvxIntentResultSink
    {
        void OnResult(MvxIntentResultEventArgs result);
    }
}
