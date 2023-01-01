// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.RectangleGeometry"/> class style setters extension methods.
/// </summary>
public static partial class RectangleGeometrySetters
{
    // Avalonia.Media.RectangleGeometry.RectProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRectangleGeometryRect(this Style style, Avalonia.Rect value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.RectangleGeometry.RectProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRectangleGeometryRect(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.RectangleGeometry.RectProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRectangleGeometryRect(this Style style, IObservable<Avalonia.Rect> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.RectangleGeometry.RectProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRectangleGeometryRect(this KeyFrame keyFrame, Avalonia.Rect value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.RectangleGeometry.RectProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRectangleGeometryRect(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.RectangleGeometry.RectProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRectangleGeometryRect(this KeyFrame keyFrame, IObservable<Avalonia.Rect> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.RectangleGeometry.RectProperty, observable.ToBinding()));
        return keyFrame;
    }
}
