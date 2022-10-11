namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.SplitButton.CommandProperty"/> property defined in <see cref="Avalonia.Controls.SplitButton"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.SplitButton,System.Windows.Input.ICommand> SplitButtonCommand => Avalonia.Controls.SplitButton.CommandProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/> property defined in <see cref="Avalonia.Controls.SplitButton"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> SplitButtonCommandParameter => Avalonia.Controls.SplitButton.CommandParameterProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/> property defined in <see cref="Avalonia.Controls.SplitButton"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.FlyoutBase> SplitButtonFlyout => Avalonia.Controls.SplitButton.FlyoutProperty;
}
