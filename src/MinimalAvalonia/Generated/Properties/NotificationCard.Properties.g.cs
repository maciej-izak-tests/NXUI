namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty"/> property defined in <see cref="Avalonia.Controls.Notifications.NotificationCard"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Notifications.NotificationCard,System.Boolean> NotificationCardIsClosing => Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/> property defined in <see cref="Avalonia.Controls.Notifications.NotificationCard"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Notifications.NotificationCard,System.Boolean> NotificationCardIsClosed => Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/> property defined in <see cref="Avalonia.Controls.Notifications.NotificationCard"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<System.Boolean> NotificationCardCloseOnClick => Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty;
}
