// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class NotificationCardExtensions
{
    // IsClosingProperty

    public static Avalonia.Data.IBinding IsClosing(this Avalonia.Controls.Notifications.NotificationCard obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty.Bind().WithMode(mode)];
    }

    // IsClosedProperty

    public static T IsClosed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty] = value;
        return obj;
    }

    public static T IsClosed<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsClosed(this Avalonia.Controls.Notifications.NotificationCard obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode)];
    }

    // CloseOnClickProperty

    public static T CloseOnClick<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty] = value;
        return obj;
    }

    public static T CloseOnClick<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding CloseOnClick(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode)];
    }
}
