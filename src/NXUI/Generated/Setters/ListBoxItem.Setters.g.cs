// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ListBoxItem"/> class style setters extension methods.
/// </summary>
public static partial class ListBoxItemSetters
{
    // Avalonia.Controls.ListBoxItem.IsSelectedProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetListBoxItemIsSelected(this Style style, System.Boolean value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetListBoxItemIsSelected(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetListBoxItemIsSelected(this Style style, IObservable<System.Boolean> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetListBoxItemIsSelected(this KeyFrame keyFrame, System.Boolean value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetListBoxItemIsSelected(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetListBoxItemIsSelected(this KeyFrame keyFrame, IObservable<System.Boolean> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, observable.ToBinding()));
        return keyFrame;
    }
}
