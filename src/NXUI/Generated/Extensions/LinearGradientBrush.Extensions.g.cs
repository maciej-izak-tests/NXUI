// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.LinearGradientBrush"/> class property extension methods.
/// </summary>
public static partial class LinearGradientBrushExtensions
{
    // Avalonia.Media.LinearGradientBrush.StartPointProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> value on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.LinearGradientBrush.StartPointProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.LinearGradientBrush StartPoint(
        this Avalonia.Media.LinearGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.LinearGradientBrush.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.LinearGradientBrush StartPoint(
        this Avalonia.Media.LinearGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.LinearGradientBrush.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> binding on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindStartPoint(
        this Avalonia.Media.LinearGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.LinearGradientBrush.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.RelativePoint> ObserveStartPoint(this Avalonia.Media.LinearGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.LinearGradientBrush.StartPointProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.LinearGradientBrush.StartPointProperty"/> property on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.LinearGradientBrush OnStartPoint(this Avalonia.Media.LinearGradientBrush obj, Action<Avalonia.Media.LinearGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.LinearGradientBrush.StartPointProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.LinearGradientBrush.EndPointProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> value on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.LinearGradientBrush.EndPointProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.LinearGradientBrush EndPoint(
        this Avalonia.Media.LinearGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.LinearGradientBrush.EndPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.LinearGradientBrush EndPoint(
        this Avalonia.Media.LinearGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.LinearGradientBrush.EndPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> binding on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindEndPoint(
        this Avalonia.Media.LinearGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.LinearGradientBrush.EndPointProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.RelativePoint> ObserveEndPoint(this Avalonia.Media.LinearGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.LinearGradientBrush.EndPointProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.LinearGradientBrush.EndPointProperty"/> property on an object of type <see cref="Avalonia.Media.LinearGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.LinearGradientBrush OnEndPoint(this Avalonia.Media.LinearGradientBrush obj, Action<Avalonia.Media.LinearGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.LinearGradientBrush.EndPointProperty);
        handler(obj, observable);
        return obj;
    }
}
