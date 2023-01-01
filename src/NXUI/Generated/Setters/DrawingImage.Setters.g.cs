// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.DrawingImage"/> class style setters extension methods.
/// </summary>
public static partial class DrawingImageSetters
{
    // Avalonia.Media.DrawingImage.DrawingProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDrawingImageDrawing(this Style style, Avalonia.Media.Drawing value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDrawingImageDrawing(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDrawingImageDrawing(this Style style, IObservable<Avalonia.Media.Drawing> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDrawingImageDrawing(this KeyFrame keyFrame, Avalonia.Media.Drawing value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDrawingImageDrawing(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDrawingImageDrawing(this KeyFrame keyFrame, IObservable<Avalonia.Media.Drawing> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, observable.ToBinding()));
        return keyFrame;
    }
}
