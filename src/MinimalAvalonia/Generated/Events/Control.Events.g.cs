namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.RequestBringIntoViewEvent"/> event defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.RequestBringIntoViewEventArgs> ControlRequestBringIntoView => Avalonia.Controls.Control.RequestBringIntoViewEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.ContextRequestedEvent"/> event defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.ContextRequestedEventArgs> ControlContextRequested => Avalonia.Controls.Control.ContextRequestedEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.LoadedEvent"/> event defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> ControlLoaded => Avalonia.Controls.Control.LoadedEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.UnloadedEvent"/> event defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> ControlUnloaded => Avalonia.Controls.Control.UnloadedEvent;
}
