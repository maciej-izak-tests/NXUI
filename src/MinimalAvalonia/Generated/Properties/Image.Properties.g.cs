namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Image.SourceProperty"/> property defined in <see cref="Avalonia.Controls.Image"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IImage> ImageSource => Avalonia.Controls.Image.SourceProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Image.StretchProperty"/> property defined in <see cref="Avalonia.Controls.Image"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Stretch> ImageStretch => Avalonia.Controls.Image.StretchProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> property defined in <see cref="Avalonia.Controls.Image"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.StretchDirection> ImageStretchDirection => Avalonia.Controls.Image.StretchDirectionProperty;
}
