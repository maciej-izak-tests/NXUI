namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> property defined in <see cref="Avalonia.Media.GeometryDrawing"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Geometry> GeometryDrawingGeometry => Avalonia.Media.GeometryDrawing.GeometryProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> property defined in <see cref="Avalonia.Media.GeometryDrawing"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> GeometryDrawingBrush => Avalonia.Media.GeometryDrawing.BrushProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> property defined in <see cref="Avalonia.Media.GeometryDrawing"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Pen> GeometryDrawingPen => Avalonia.Media.GeometryDrawing.PenProperty;
}
