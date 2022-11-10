// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Shapes.Rectangle"/> class property extension methods.
/// </summary>
public static partial class RectangleExtensions
{
    // Avalonia.Controls.Shapes.Rectangle.RadiusXProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusX<T>(this T obj, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle
    {
        obj[Avalonia.Controls.Shapes.Rectangle.RadiusXProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusX<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Rectangle
    {
        var descriptor = Avalonia.Controls.Shapes.Rectangle.RadiusXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusX<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Rectangle
    {
        var descriptor = Avalonia.Controls.Shapes.Rectangle.RadiusXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRadiusX(
        this Avalonia.Controls.Shapes.Rectangle obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Shapes.Rectangle.RadiusXProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveRadiusX(this Avalonia.Controls.Shapes.Rectangle obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRadiusX<T>(this T obj, Action<Avalonia.Controls.Shapes.Rectangle, IObservable<System.Double>> handler) where T : Avalonia.Controls.Shapes.Rectangle
    {
        var observable = obj.GetObservable(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Shapes.Rectangle.RadiusYProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusY<T>(this T obj, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle
    {
        obj[Avalonia.Controls.Shapes.Rectangle.RadiusYProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusY<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Rectangle
    {
        var descriptor = Avalonia.Controls.Shapes.Rectangle.RadiusYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusY<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Rectangle
    {
        var descriptor = Avalonia.Controls.Shapes.Rectangle.RadiusYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRadiusY(
        this Avalonia.Controls.Shapes.Rectangle obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Shapes.Rectangle.RadiusYProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveRadiusY(this Avalonia.Controls.Shapes.Rectangle obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Shapes.Rectangle.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRadiusY<T>(this T obj, Action<Avalonia.Controls.Shapes.Rectangle, IObservable<System.Double>> handler) where T : Avalonia.Controls.Shapes.Rectangle
    {
        var observable = obj.GetObservable(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty);
        handler(obj, observable);
        return obj;
    }
}
