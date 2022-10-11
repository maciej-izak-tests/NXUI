namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> property defined in <see cref="Avalonia.Media.DrawingGroup"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> DrawingGroupOpacity => Avalonia.Media.DrawingGroup.OpacityProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> property defined in <see cref="Avalonia.Media.DrawingGroup"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Transform> DrawingGroupTransform => Avalonia.Media.DrawingGroup.TransformProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> property defined in <see cref="Avalonia.Media.DrawingGroup"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.Geometry> DrawingGroupClipGeometry => Avalonia.Media.DrawingGroup.ClipGeometryProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> property defined in <see cref="Avalonia.Media.DrawingGroup"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> DrawingGroupOpacityMask => Avalonia.Media.DrawingGroup.OpacityMaskProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> property defined in <see cref="Avalonia.Media.DrawingGroup"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Media.DrawingGroup,Avalonia.Media.DrawingCollection> DrawingGroupChildren => Avalonia.Media.DrawingGroup.ChildrenProperty;
}
