// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.Geometry"/> class style setters extension methods.
/// </summary>
public static partial class GeometrySetters
{
    // Avalonia.Media.Geometry.TransformProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Geometry.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGeometryTransform(this Style style, Avalonia.Media.Transform value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Geometry.TransformProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Geometry.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGeometryTransform(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Geometry.TransformProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Geometry.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGeometryTransform(this Style style, IObservable<Avalonia.Media.Transform> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Geometry.TransformProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Geometry.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGeometryTransform(this KeyFrame keyFrame, Avalonia.Media.Transform value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Geometry.TransformProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Geometry.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGeometryTransform(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Geometry.TransformProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Geometry.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGeometryTransform(this KeyFrame keyFrame, IObservable<Avalonia.Media.Transform> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Geometry.TransformProperty, observable.ToBinding()));
        return keyFrame;
    }
}
