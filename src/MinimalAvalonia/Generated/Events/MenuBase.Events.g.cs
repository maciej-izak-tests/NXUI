namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuBase.MenuOpenedEvent"/> event defined in <see cref="Avalonia.Controls.MenuBase"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> MenuBaseMenuOpened => Avalonia.Controls.MenuBase.MenuOpenedEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuBase.MenuClosedEvent"/> event defined in <see cref="Avalonia.Controls.MenuBase"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> MenuBaseMenuClosed => Avalonia.Controls.MenuBase.MenuClosedEvent;
}
