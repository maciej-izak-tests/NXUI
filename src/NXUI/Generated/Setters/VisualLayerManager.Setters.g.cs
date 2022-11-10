// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Primitives.VisualLayerManager"/> class style setters extension methods.
/// </summary>
public static partial class VisualLayerManagerSetters
{
    // Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetVisualLayerManagerChromeOverlayLayer(this Style style, Avalonia.Controls.Primitives.ChromeOverlayLayer value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetVisualLayerManagerChromeOverlayLayer(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetVisualLayerManagerChromeOverlayLayer(this Style style, IObservable<Avalonia.Controls.Primitives.ChromeOverlayLayer> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetVisualLayerManagerChromeOverlayLayer(this KeyFrame keyFrame, Avalonia.Controls.Primitives.ChromeOverlayLayer value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetVisualLayerManagerChromeOverlayLayer(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetVisualLayerManagerChromeOverlayLayer(this KeyFrame keyFrame, IObservable<Avalonia.Controls.Primitives.ChromeOverlayLayer> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.VisualLayerManager.ChromeOverlayLayerProperty, observable.ToBinding()));
        return keyFrame;
    }
}
