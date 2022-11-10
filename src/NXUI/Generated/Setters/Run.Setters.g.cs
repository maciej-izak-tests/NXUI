// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Documents.Run"/> class style setters extension methods.
/// </summary>
public static partial class RunSetters
{
    // Avalonia.Controls.Documents.Run.TextProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Documents.Run.TextProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRunText(this Style style, System.String value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Documents.Run.TextProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Documents.Run.TextProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRunText(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Documents.Run.TextProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Documents.Run.TextProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRunText(this Style style, IObservable<System.String> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Documents.Run.TextProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Documents.Run.TextProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRunText(this KeyFrame keyFrame, System.String value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Documents.Run.TextProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Documents.Run.TextProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRunText(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Documents.Run.TextProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Documents.Run.TextProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRunText(this KeyFrame keyFrame, IObservable<System.String> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Documents.Run.TextProperty, observable.ToBinding()));
        return keyFrame;
    }
}
