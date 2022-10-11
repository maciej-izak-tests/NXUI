namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/> property defined in <see cref="Avalonia.Media.PathGeometry"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Media.PathGeometry,Avalonia.Media.PathFigures> PathGeometryFigures => Avalonia.Media.PathGeometry.FiguresProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> property defined in <see cref="Avalonia.Media.PathGeometry"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.FillRule> PathGeometryFillRule => Avalonia.Media.PathGeometry.FillRuleProperty;
}
