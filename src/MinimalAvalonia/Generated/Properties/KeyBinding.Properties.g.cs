namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Input.KeyBinding.CommandProperty"/> property defined in <see cref="Avalonia.Input.KeyBinding"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Windows.Input.ICommand> KeyBindingCommand => Avalonia.Input.KeyBinding.CommandProperty;

    /// <summary>
    /// The <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/> property defined in <see cref="Avalonia.Input.KeyBinding"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> KeyBindingCommandParameter => Avalonia.Input.KeyBinding.CommandParameterProperty;

    /// <summary>
    /// The <see cref="Avalonia.Input.KeyBinding.GestureProperty"/> property defined in <see cref="Avalonia.Input.KeyBinding"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> KeyBindingGesture => Avalonia.Input.KeyBinding.GestureProperty;
}
