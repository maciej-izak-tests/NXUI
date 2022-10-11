namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.CommandProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.MenuItem,System.Windows.Input.ICommand> MenuItemCommand => Avalonia.Controls.MenuItem.CommandProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.HotKeyProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> MenuItemHotKey => Avalonia.Controls.MenuItem.HotKeyProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.CommandParameterProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> MenuItemCommandParameter => Avalonia.Controls.MenuItem.CommandParameterProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.IconProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> MenuItemIcon => Avalonia.Controls.MenuItem.IconProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.InputGestureProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> MenuItemInputGesture => Avalonia.Controls.MenuItem.InputGestureProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.IsSelectedProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> MenuItemIsSelected => Avalonia.Controls.MenuItem.IsSelectedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.IsSubMenuOpenProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> MenuItemIsSubMenuOpen => Avalonia.Controls.MenuItem.IsSubMenuOpenProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.StaysOpenOnClickProperty"/> property defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> MenuItemStaysOpenOnClick => Avalonia.Controls.MenuItem.StaysOpenOnClickProperty;
}
