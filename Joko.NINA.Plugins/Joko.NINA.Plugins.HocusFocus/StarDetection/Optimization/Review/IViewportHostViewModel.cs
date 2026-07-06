#region "copyright"
/*
    Copyright © 2021 - 2026 George Hilios <ghilios+NINA@googlemail.com>

    This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/
#endregion "copyright"

using System;
using System.Windows.Input;

namespace NINA.Joko.Plugins.HocusFocus.StarDetection.Optimization.Review {

    /// <summary>Minimal VM contract the shared review viewport host drives (F08): zoom/pan state + image size, a
    /// re-fit signal, a post-change notification so the inverse-zoom marker bindings refresh, and prev/next nav.</summary>
    public interface IViewportHostViewModel {
        StarReviewViewport Viewport { get; }
        double ImageWidth { get; }
        double ImageHeight { get; }
        void NotifyViewportChanged();
        event EventHandler FitRequested;
        ICommand PrevCommand { get; }
        ICommand NextCommand { get; }
    }
}
