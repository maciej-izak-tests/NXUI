namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TopLevel.ClientSizeProperty"/> property defined in <see cref="Avalonia.Controls.TopLevel"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TopLevel,Avalonia.Size> TopLevelClientSize => Avalonia.Controls.TopLevel.ClientSizeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TopLevel.FrameSizeProperty"/> property defined in <see cref="Avalonia.Controls.TopLevel"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TopLevel,System.Nullable<Avalonia.Size>> TopLevelFrameSize => Avalonia.Controls.TopLevel.FrameSizeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/> property defined in <see cref="Avalonia.Controls.TopLevel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Input.IInputElement> TopLevelPointerOverElement => Avalonia.Controls.TopLevel.PointerOverElementProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property defined in <see cref="Avalonia.Controls.TopLevel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.WindowTransparencyLevel> TopLevelTransparencyLevelHint => Avalonia.Controls.TopLevel.TransparencyLevelHintProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty"/> property defined in <see cref="Avalonia.Controls.TopLevel"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TopLevel,Avalonia.Controls.WindowTransparencyLevel> TopLevelActualTransparencyLevel => Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/> property defined in <see cref="Avalonia.Controls.TopLevel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TopLevelTransparencyBackgroundFallback => Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty;
}
