namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Viewbox.StretchProperty"/> property defined in <see cref="Avalonia.Controls.Viewbox"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Stretch> ViewboxStretch => Avalonia.Controls.Viewbox.StretchProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Viewbox.StretchDirectionProperty"/> property defined in <see cref="Avalonia.Controls.Viewbox"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.StretchDirection> ViewboxStretchDirection => Avalonia.Controls.Viewbox.StretchDirectionProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Viewbox.ChildProperty"/> property defined in <see cref="Avalonia.Controls.Viewbox"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.IControl> ViewboxChild => Avalonia.Controls.Viewbox.ChildProperty;
}
