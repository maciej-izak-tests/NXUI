namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/> property defined in <see cref="Avalonia.Media.PolylineGeometry"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Media.PolylineGeometry,Avalonia.Points> PolylineGeometryPoints => Avalonia.Media.PolylineGeometry.PointsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/> property defined in <see cref="Avalonia.Media.PolylineGeometry"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> PolylineGeometryIsFilled => Avalonia.Media.PolylineGeometry.IsFilledProperty;
}
