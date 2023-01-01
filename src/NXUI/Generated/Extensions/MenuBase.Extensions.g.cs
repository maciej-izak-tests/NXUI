// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.MenuBase"/> class property extension methods.
/// </summary>
public static partial class MenuBaseExtensions
{
    // Avalonia.Controls.MenuBase.IsOpenProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.MenuBase.IsOpenProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.MenuBase.IsOpenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsOpen(
        this Avalonia.Controls.MenuBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.MenuBase.IsOpenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.MenuBase.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsOpen(this Avalonia.Controls.MenuBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuBase.IsOpenProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.MenuBase.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.MenuBase OnIsOpen(this Avalonia.Controls.MenuBase obj, Action<Avalonia.Controls.MenuBase, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.MenuBase.IsOpenProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.MenuBase.MenuOpenedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.MenuBase.MenuOpenedEvent"/> event on an object of type <see cref="Avalonia.Controls.MenuBase"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnMenuOpenedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.MenuBase
    {
        obj.AddHandler(Avalonia.Controls.MenuBase.MenuOpenedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.MenuBase.MenuOpenedEvent"/> event on an object of type <see cref="Avalonia.Controls.MenuBase"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnMenuOpened<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.MenuBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.MenuBase.MenuOpenedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.MenuBase.MenuOpenedEvent"/> event on an object of type <see cref="Avalonia.Controls.MenuBase"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnMenuOpened(
        this Avalonia.Controls.MenuBase obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.MenuBase.MenuOpenedEvent, routes);
    }

    // Avalonia.Controls.MenuBase.MenuClosedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.MenuBase.MenuClosedEvent"/> event on an object of type <see cref="Avalonia.Controls.MenuBase"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnMenuClosedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.MenuBase
    {
        obj.AddHandler(Avalonia.Controls.MenuBase.MenuClosedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.MenuBase.MenuClosedEvent"/> event on an object of type <see cref="Avalonia.Controls.MenuBase"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnMenuClosed<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.MenuBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.MenuBase.MenuClosedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.MenuBase.MenuClosedEvent"/> event on an object of type <see cref="Avalonia.Controls.MenuBase"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnMenuClosed(
        this Avalonia.Controls.MenuBase obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.MenuBase.MenuClosedEvent, routes);
    }

    // Avalonia.Controls.MenuBase.MenuOpened

    /// <summary>
    /// Adds a handler to the `MenuOpened` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMenuOpenedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.MenuBase
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.MenuOpened += h, 
                h => obj.MenuOpened -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `MenuOpened` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `MenuOpened` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnMenuOpenedEvent(this Avalonia.Controls.MenuBase obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.MenuOpened += h, 
                h => obj.MenuOpened -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.MenuBase.MenuClosed

    /// <summary>
    /// Adds a handler to the `MenuClosed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMenuClosedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.MenuBase
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.MenuClosed += h, 
                h => obj.MenuClosed -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `MenuClosed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `MenuClosed` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnMenuClosedEvent(this Avalonia.Controls.MenuBase obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.MenuClosed += h, 
                h => obj.MenuClosed -= h)
            .Select(x => x.EventArgs);
    }
}
