﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;

namespace MvvmCross.Forms.Views.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MvxTabbedPagePresentationAttribute : MvxPagePresentationAttribute
    {
        public MvxTabbedPagePresentationAttribute(TabbedPosition position = TabbedPosition.Tab)
        {
            Position = position;
        }

        public TabbedPosition Position { get; set; }
    }

    public enum TabbedPosition
    {
        Root,
        Tab
    }
}