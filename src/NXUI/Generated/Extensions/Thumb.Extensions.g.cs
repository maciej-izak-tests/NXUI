// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Primitives.Thumb"/> class property extension methods.
/// </summary>
public static partial class ThumbExtensions
{
    // Avalonia.Controls.Primitives.Thumb.DragStartedEvent

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="action"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragStartedHandler<T>(
        this T obj,
        Action<T, Avalonia.Input.VectorEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb
    {
        obj.AddHandler(Avalonia.Controls.Primitives.Thumb.DragStartedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragStarted<T>(
        this T obj, Action<T, IObservable<Avalonia.Input.VectorEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.Thumb.DragStartedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="routes"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Input.VectorEventArgs> ObserveOnDragStarted(
        this Avalonia.Controls.Primitives.Thumb obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.Thumb.DragStartedEvent, routes);
    }

    // Avalonia.Controls.Primitives.Thumb.DragDeltaEvent

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="action"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragDeltaHandler<T>(
        this T obj,
        Action<T, Avalonia.Input.VectorEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb
    {
        obj.AddHandler(Avalonia.Controls.Primitives.Thumb.DragDeltaEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragDelta<T>(
        this T obj, Action<T, IObservable<Avalonia.Input.VectorEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.Thumb.DragDeltaEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="routes"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Input.VectorEventArgs> ObserveOnDragDelta(
        this Avalonia.Controls.Primitives.Thumb obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.Thumb.DragDeltaEvent, routes);
    }

    // Avalonia.Controls.Primitives.Thumb.DragCompletedEvent

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="action"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragCompletedHandler<T>(
        this T obj,
        Action<T, Avalonia.Input.VectorEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb
    {
        obj.AddHandler(Avalonia.Controls.Primitives.Thumb.DragCompletedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragCompleted<T>(
        this T obj, Action<T, IObservable<Avalonia.Input.VectorEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.Thumb.DragCompletedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="routes"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Input.VectorEventArgs> ObserveOnDragCompleted(
        this Avalonia.Controls.Primitives.Thumb obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.Thumb.DragCompletedEvent, routes);
    }

    // Avalonia.Controls.Primitives.Thumb.DragStarted

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragStartedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Input.VectorEventArgs>> handler) where T : Avalonia.Controls.Primitives.Thumb
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Input.VectorEventArgs>, Avalonia.Input.VectorEventArgs>(
                h => obj.DragStarted += h, 
                h => obj.DragStarted -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Input.VectorEventArgs> ObserveOnDragStartedEvent(this Avalonia.Controls.Primitives.Thumb obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Input.VectorEventArgs>, Avalonia.Input.VectorEventArgs>(
                h => obj.DragStarted += h, 
                h => obj.DragStarted -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Primitives.Thumb.DragDelta

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragDeltaEvent<T>(this T obj, Action<T, IObservable<Avalonia.Input.VectorEventArgs>> handler) where T : Avalonia.Controls.Primitives.Thumb
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Input.VectorEventArgs>, Avalonia.Input.VectorEventArgs>(
                h => obj.DragDelta += h, 
                h => obj.DragDelta -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Input.VectorEventArgs> ObserveOnDragDeltaEvent(this Avalonia.Controls.Primitives.Thumb obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Input.VectorEventArgs>, Avalonia.Input.VectorEventArgs>(
                h => obj.DragDelta += h, 
                h => obj.DragDelta -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Primitives.Thumb.DragCompleted

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnDragCompletedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Input.VectorEventArgs>> handler) where T : Avalonia.Controls.Primitives.Thumb
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Input.VectorEventArgs>, Avalonia.Input.VectorEventArgs>(
                h => obj.DragCompleted += h, 
                h => obj.DragCompleted -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Input.VectorEventArgs> ObserveOnDragCompletedEvent(this Avalonia.Controls.Primitives.Thumb obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Input.VectorEventArgs>, Avalonia.Input.VectorEventArgs>(
                h => obj.DragCompleted += h, 
                h => obj.DragCompleted -= h)
            .Select(x => x.EventArgs);
    }
}
