namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty"/> property defined in <see cref="Avalonia.Controls.Primitives.AdornerLayer"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<Avalonia.Visual> AdornerLayerAdornedElement => Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty"/> property defined in <see cref="Avalonia.Controls.Primitives.AdornerLayer"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<System.Boolean> AdornerLayerIsClipEnabled => Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty"/> property defined in <see cref="Avalonia.Controls.Primitives.AdornerLayer"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<Avalonia.Controls.Control> AdornerLayerAdorner => Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty;
}
