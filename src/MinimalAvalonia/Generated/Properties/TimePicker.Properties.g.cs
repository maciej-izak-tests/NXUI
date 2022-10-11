namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/> property defined in <see cref="Avalonia.Controls.TimePicker"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TimePicker,System.Int32> TimePickerMinuteIncrement => Avalonia.Controls.TimePicker.MinuteIncrementProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TimePicker.HeaderProperty"/> property defined in <see cref="Avalonia.Controls.TimePicker"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> TimePickerHeader => Avalonia.Controls.TimePicker.HeaderProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TimePicker.HeaderTemplateProperty"/> property defined in <see cref="Avalonia.Controls.TimePicker"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> TimePickerHeaderTemplate => Avalonia.Controls.TimePicker.HeaderTemplateProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/> property defined in <see cref="Avalonia.Controls.TimePicker"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TimePicker,System.String> TimePickerClockIdentifier => Avalonia.Controls.TimePicker.ClockIdentifierProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/> property defined in <see cref="Avalonia.Controls.TimePicker"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TimePicker,System.Nullable<System.TimeSpan>> TimePickerSelectedTime => Avalonia.Controls.TimePicker.SelectedTimeProperty;
}
