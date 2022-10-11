namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.ClickModeProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.ClickMode> ButtonClickMode => Avalonia.Controls.Button.ClickModeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.CommandProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Button,System.Windows.Input.ICommand> ButtonCommand => Avalonia.Controls.Button.CommandProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.HotKeyProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> ButtonHotKey => Avalonia.Controls.Button.HotKeyProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.CommandParameterProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> ButtonCommandParameter => Avalonia.Controls.Button.CommandParameterProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.IsDefaultProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> ButtonIsDefault => Avalonia.Controls.Button.IsDefaultProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.IsCancelProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> ButtonIsCancel => Avalonia.Controls.Button.IsCancelProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.IsPressedProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> ButtonIsPressed => Avalonia.Controls.Button.IsPressedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Button.FlyoutProperty"/> property defined in <see cref="Avalonia.Controls.Button"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.FlyoutBase> ButtonFlyout => Avalonia.Controls.Button.FlyoutProperty;
}
