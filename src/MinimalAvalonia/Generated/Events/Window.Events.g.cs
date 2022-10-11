namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Window.WindowClosedEvent"/> event defined in <see cref="Avalonia.Controls.Window"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> WindowWindowClosed => Avalonia.Controls.Window.WindowClosedEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Window.WindowOpenedEvent"/> event defined in <see cref="Avalonia.Controls.Window"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> WindowWindowOpened => Avalonia.Controls.Window.WindowOpenedEvent;
}
