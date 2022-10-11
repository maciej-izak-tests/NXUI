namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.ScrollViewer.ScrollChangedEvent"/> event defined in <see cref="Avalonia.Controls.ScrollViewer"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.ScrollChangedEventArgs> ScrollViewerScrollChanged => Avalonia.Controls.ScrollViewer.ScrollChangedEvent;
}
