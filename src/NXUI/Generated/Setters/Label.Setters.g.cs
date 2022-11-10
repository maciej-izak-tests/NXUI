// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Label"/> class style setters extension methods.
/// </summary>
public static partial class LabelSetters
{
    // Avalonia.Controls.Label.TargetProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Label.TargetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLabelTarget(this Style style, Avalonia.Input.IInputElement value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Label.TargetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLabelTarget(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Label.TargetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLabelTarget(this Style style, IObservable<Avalonia.Input.IInputElement> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Label.TargetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLabelTarget(this KeyFrame keyFrame, Avalonia.Input.IInputElement value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Label.TargetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLabelTarget(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Label.TargetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLabelTarget(this KeyFrame keyFrame, IObservable<Avalonia.Input.IInputElement> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, observable.ToBinding()));
        return keyFrame;
    }
}
