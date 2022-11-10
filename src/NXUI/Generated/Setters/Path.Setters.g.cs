// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Shapes.Path"/> class style setters extension methods.
/// </summary>
public static partial class PathSetters
{
    // Avalonia.Controls.Shapes.Path.DataProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Path.DataProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPathData(this Style style, Avalonia.Media.Geometry value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Path.DataProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Path.DataProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPathData(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Path.DataProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Path.DataProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPathData(this Style style, IObservable<Avalonia.Media.Geometry> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Path.DataProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Path.DataProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPathData(this KeyFrame keyFrame, Avalonia.Media.Geometry value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Path.DataProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Path.DataProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPathData(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Path.DataProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Path.DataProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPathData(this KeyFrame keyFrame, IObservable<Avalonia.Media.Geometry> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Path.DataProperty, observable.ToBinding()));
        return keyFrame;
    }
}
