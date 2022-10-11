namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.FirstDayOfWeekProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.DayOfWeek> CalendarFirstDayOfWeek => Avalonia.Controls.Calendar.FirstDayOfWeekProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.IsTodayHighlightedProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> CalendarIsTodayHighlighted => Avalonia.Controls.Calendar.IsTodayHighlightedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.HeaderBackgroundProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> CalendarHeaderBackground => Avalonia.Controls.Calendar.HeaderBackgroundProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.DisplayModeProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.CalendarMode> CalendarDisplayMode => Avalonia.Controls.Calendar.DisplayModeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.SelectionModeProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.CalendarSelectionMode> CalendarSelectionMode => Avalonia.Controls.Calendar.SelectionModeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.SelectedDateProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.Nullable<System.DateTime>> CalendarSelectedDate => Avalonia.Controls.Calendar.SelectedDateProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.DisplayDateProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.DateTime> CalendarDisplayDate => Avalonia.Controls.Calendar.DisplayDateProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.DisplayDateStartProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.Nullable<System.DateTime>> CalendarDisplayDateStart => Avalonia.Controls.Calendar.DisplayDateStartProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Calendar.DisplayDateEndProperty"/> property defined in <see cref="Avalonia.Controls.Calendar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.Nullable<System.DateTime>> CalendarDisplayDateEnd => Avalonia.Controls.Calendar.DisplayDateEndProperty;
}
