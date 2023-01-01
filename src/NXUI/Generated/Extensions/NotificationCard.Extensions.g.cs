// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Notifications.NotificationCard"/> class property extension methods.
/// </summary>
public static partial class NotificationCardExtensions
{
    // Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsClosing(
        this Avalonia.Controls.Notifications.NotificationCard obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsClosing(this Avalonia.Controls.Notifications.NotificationCard obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Notifications.NotificationCard OnIsClosing(this Avalonia.Controls.Notifications.NotificationCard obj, Action<Avalonia.Controls.Notifications.NotificationCard, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsClosed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsClosed<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsClosed<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsClosed(
        this Avalonia.Controls.Notifications.NotificationCard obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsClosed(this Avalonia.Controls.Notifications.NotificationCard obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsClosed<T>(this T obj, Action<Avalonia.Controls.Notifications.NotificationCard, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CloseOnClick<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CloseOnClick<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Button
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CloseOnClick<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Button
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCloseOnClick(
        this Avalonia.Controls.Button obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveCloseOnClick(this Avalonia.Controls.Button obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCloseOnClick<T>(this T obj, Action<Avalonia.Controls.Button, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Button
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent"/> event on an object of type <see cref="Avalonia.Controls.Notifications.NotificationCard"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnNotificationClosedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj.AddHandler(Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent"/> event on an object of type <see cref="Avalonia.Controls.Notifications.NotificationCard"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnNotificationClosed<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent"/> event on an object of type <see cref="Avalonia.Controls.Notifications.NotificationCard"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnNotificationClosed(
        this Avalonia.Controls.Notifications.NotificationCard obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, routes);
    }

    // Avalonia.Controls.Notifications.NotificationCard.NotificationClosed

    /// <summary>
    /// Adds a handler to the `NotificationClosed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnNotificationClosedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.NotificationClosed += h, 
                h => obj.NotificationClosed -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `NotificationClosed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `NotificationClosed` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnNotificationClosedEvent(this Avalonia.Controls.Notifications.NotificationCard obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.NotificationClosed += h, 
                h => obj.NotificationClosed -= h)
            .Select(x => x.EventArgs);
    }
}
