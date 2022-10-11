namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Decorator.ChildProperty"/> property defined in <see cref="Avalonia.Controls.Decorator"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.IControl> DecoratorChild => Avalonia.Controls.Decorator.ChildProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Decorator.PaddingProperty"/> property defined in <see cref="Avalonia.Controls.Decorator"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Thickness> DecoratorPadding => Avalonia.Controls.Decorator.PaddingProperty;
}
