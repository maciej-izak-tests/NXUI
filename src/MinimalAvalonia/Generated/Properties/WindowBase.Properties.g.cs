namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.WindowBase.IsActiveProperty"/> property defined in <see cref="Avalonia.Controls.WindowBase"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.WindowBase,System.Boolean> WindowBaseIsActive => Avalonia.Controls.WindowBase.IsActiveProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.WindowBase.OwnerProperty"/> property defined in <see cref="Avalonia.Controls.WindowBase"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.WindowBase,Avalonia.Controls.WindowBase> WindowBaseOwner => Avalonia.Controls.WindowBase.OwnerProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/> property defined in <see cref="Avalonia.Controls.WindowBase"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> WindowBaseTopmost => Avalonia.Controls.WindowBase.TopmostProperty;
}
