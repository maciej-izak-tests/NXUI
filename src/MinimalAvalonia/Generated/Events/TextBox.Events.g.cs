namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TextBox.CopyingToClipboardEvent"/> event defined in <see cref="Avalonia.Controls.TextBox"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> TextBoxCopyingToClipboard => Avalonia.Controls.TextBox.CopyingToClipboardEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TextBox.CuttingToClipboardEvent"/> event defined in <see cref="Avalonia.Controls.TextBox"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> TextBoxCuttingToClipboard => Avalonia.Controls.TextBox.CuttingToClipboardEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TextBox.PastingFromClipboardEvent"/> event defined in <see cref="Avalonia.Controls.TextBox"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> TextBoxPastingFromClipboard => Avalonia.Controls.TextBox.PastingFromClipboardEvent;
}
