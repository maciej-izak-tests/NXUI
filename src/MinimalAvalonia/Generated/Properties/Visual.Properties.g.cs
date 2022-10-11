namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Visual.BoundsProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Visual,Avalonia.Rect> VisualBounds => Avalonia.Visual.BoundsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.TransformedBoundsProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Visual,System.Nullable<Avalonia.VisualTree.TransformedBounds>> VisualTransformedBounds => Avalonia.Visual.TransformedBoundsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.ClipToBoundsProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> VisualClipToBounds => Avalonia.Visual.ClipToBoundsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.ClipProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Geometry> VisualClip => Avalonia.Visual.ClipProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.IsVisibleProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> VisualIsVisible => Avalonia.Visual.IsVisibleProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.OpacityProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> VisualOpacity => Avalonia.Visual.OpacityProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.OpacityMaskProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> VisualOpacityMask => Avalonia.Visual.OpacityMaskProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.HasMirrorTransformProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Visual,System.Boolean> VisualHasMirrorTransform => Avalonia.Visual.HasMirrorTransformProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.RenderTransformProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.ITransform> VisualRenderTransform => Avalonia.Visual.RenderTransformProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.RenderTransformOriginProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.RelativePoint> VisualRenderTransformOrigin => Avalonia.Visual.RenderTransformOriginProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.VisualParentProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Visual,Avalonia.VisualTree.IVisual> VisualVisualParent => Avalonia.Visual.VisualParentProperty;

    /// <summary>
    /// The <see cref="Avalonia.Visual.ZIndexProperty"/> property defined in <see cref="Avalonia.Visual"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Int32> VisualZIndex => Avalonia.Visual.ZIndexProperty;
}
