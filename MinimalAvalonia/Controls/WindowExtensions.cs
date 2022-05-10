﻿namespace MinimalAvalonia.Controls;

public static class WindowExtensions
{
    public static Window SizeToContentManual(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = SizeToContent.Manual;
        return window;
    }

    public static Window SizeToContentWidth(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = SizeToContent.Width;
        return window;
    }

    public static Window SizeToContentHeight(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = SizeToContent.Height;
        return window;
    }

    public static Window SizeToContentWidthAndHeight(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = SizeToContent.WidthAndHeight;
        return window;
    }

    public static Window Title(this Window window, string title)
    {
        window[Avalonia.Controls.Window.TitleProperty] = title;
        return window;
    }

    // TODO:
    // HasSystemDecorationsProperty
    // ExtendClientAreaToDecorationsHintProperty
    // ExtendClientAreaChromeHintsProperty
    // ExtendClientAreaTitleBarHeightHintProperty
    // SystemDecorationsProperty
    // ShowActivatedProperty
    // ShowInTaskbarProperty
    // WindowStateProperty
    // IconProperty
    // WindowStartupLocationProperty
    // CanResizeProperty
    // WindowClosedEvent
    // WindowOpenedEvent
}
