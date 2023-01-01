// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl"/> class style setters extension methods.
/// </summary>
public static partial class HeaderedSelectingItemsControlSetters
{
    // Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetHeaderedSelectingItemsControlHeader(this Style style, System.Object value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetHeaderedSelectingItemsControlHeader(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetHeaderedSelectingItemsControlHeader(this Style style, IObservable<System.Object> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetHeaderedSelectingItemsControlHeader(this KeyFrame keyFrame, System.Object value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetHeaderedSelectingItemsControlHeader(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetHeaderedSelectingItemsControlHeader(this KeyFrame keyFrame, IObservable<System.Object> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, observable.ToBinding()));
        return keyFrame;
    }
}
