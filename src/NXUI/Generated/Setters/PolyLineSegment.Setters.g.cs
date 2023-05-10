// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.PolyLineSegment"/> class style setters extension methods.
/// </summary>
public static partial class PolyLineSegmentSetters
{
    // Avalonia.Media.PolyLineSegment.PointsProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPolyLineSegmentPoints(this Style style, System.Collections.Generic.IList<Avalonia.Point> value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.PolyLineSegment.PointsProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPolyLineSegmentPoints(this KeyFrame keyFrame, System.Collections.Generic.IList<Avalonia.Point> value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.PolyLineSegment.PointsProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPolyLineSegmentPoints(this Style style, IObservable<System.Collections.Generic.IList<Avalonia.Point>> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.PolyLineSegment.PointsProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPolyLineSegmentPoints(this KeyFrame keyFrame, IObservable<System.Collections.Generic.IList<Avalonia.Point>> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.PolyLineSegment.PointsProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPolyLineSegmentPoints(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.PolyLineSegment.PointsProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPolyLineSegmentPoints(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.PolyLineSegment.PointsProperty, binding));
        return keyFrame;
    }
}
