// <auto-generated />
namespace NXUI;

/// <summary>
/// The avalonia builders.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.</returns>
    public static Avalonia.Media.PolylineGeometry PolylineGeometry()
        => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.PolylineGeometry"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.</returns>
    public static Avalonia.Media.PolylineGeometry PolylineGeometry(out Avalonia.Media.PolylineGeometry @ref)
        => @ref = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.
    /// </summary>
    /// <param name="points">The points value.</param>
    /// <param name="isFilled">The isFilled value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.</returns>
    public static Avalonia.Media.PolylineGeometry PolylineGeometry(System.Collections.Generic.IEnumerable<Avalonia.Point> points, System.Boolean isFilled)
        => new(points, isFilled);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.PolylineGeometry"/> instantiated class.</param>
    /// <param name="points">The points value.</param>
    /// <param name="isFilled">The isFilled value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolylineGeometry"/> class.</returns>
    public static Avalonia.Media.PolylineGeometry PolylineGeometry(out Avalonia.Media.PolylineGeometry @ref, System.Collections.Generic.IEnumerable<Avalonia.Point> points, System.Boolean isFilled)
        => @ref = new(points, isFilled);
}
