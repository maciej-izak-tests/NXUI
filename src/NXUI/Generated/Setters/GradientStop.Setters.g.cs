// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.GradientStop"/> class style setters extension methods.
/// </summary>
public static partial class GradientStopSetters
{
    // Avalonia.Media.GradientStop.OffsetProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.GradientStop.OffsetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGradientStopOffset(this Style style, System.Double value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.GradientStop.OffsetProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.GradientStop.OffsetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGradientStopOffset(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.GradientStop.OffsetProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.GradientStop.OffsetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGradientStopOffset(this Style style, IObservable<System.Double> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.GradientStop.OffsetProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.GradientStop.OffsetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGradientStopOffset(this KeyFrame keyFrame, System.Double value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.GradientStop.OffsetProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.GradientStop.OffsetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGradientStopOffset(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.GradientStop.OffsetProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.GradientStop.OffsetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGradientStopOffset(this KeyFrame keyFrame, IObservable<System.Double> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.GradientStop.OffsetProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.GradientStop.ColorProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.GradientStop.ColorProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGradientStopColor(this Style style, Avalonia.Media.Color value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.GradientStop.ColorProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.GradientStop.ColorProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGradientStopColor(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.GradientStop.ColorProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.GradientStop.ColorProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetGradientStopColor(this Style style, IObservable<Avalonia.Media.Color> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.GradientStop.ColorProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.GradientStop.ColorProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGradientStopColor(this KeyFrame keyFrame, Avalonia.Media.Color value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.GradientStop.ColorProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.GradientStop.ColorProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGradientStopColor(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.GradientStop.ColorProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.GradientStop.ColorProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetGradientStopColor(this KeyFrame keyFrame, IObservable<Avalonia.Media.Color> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.GradientStop.ColorProperty, observable.ToBinding()));
        return keyFrame;
    }
}
