namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.FocusAdornerProperty"/> property defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> ControlFocusAdorner => Avalonia.Controls.Control.FocusAdornerProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.TagProperty"/> property defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> ControlTag => Avalonia.Controls.Control.TagProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.ContextMenuProperty"/> property defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.ContextMenu> ControlContextMenu => Avalonia.Controls.Control.ContextMenuProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.ContextFlyoutProperty"/> property defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.FlyoutBase> ControlContextFlyout => Avalonia.Controls.Control.ContextFlyoutProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Control.FlowDirectionProperty"/> property defined in <see cref="Avalonia.Controls.Control"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<Avalonia.Media.FlowDirection> ControlFlowDirection => Avalonia.Controls.Control.FlowDirectionProperty;
}
