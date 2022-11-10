// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Layout.WrapLayout"/> class property extension methods.
/// </summary>
public static partial class WrapLayoutExtensions
{
    // Avalonia.Layout.WrapLayout.HorizontalSpacingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalSpacing<T>(this T obj, System.Double value) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.HorizontalSpacingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalSpacing<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Layout.WrapLayout
    {
        var descriptor = Avalonia.Layout.WrapLayout.HorizontalSpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalSpacing<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Layout.WrapLayout
    {
        var descriptor = Avalonia.Layout.WrapLayout.HorizontalSpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHorizontalSpacing(
        this Avalonia.Layout.WrapLayout obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Layout.WrapLayout.HorizontalSpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveHorizontalSpacing(this Avalonia.Layout.WrapLayout obj)
    {
        return obj.GetObservable(Avalonia.Layout.WrapLayout.HorizontalSpacingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Layout.WrapLayout.HorizontalSpacingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHorizontalSpacing<T>(this T obj, Action<Avalonia.Layout.WrapLayout, IObservable<System.Double>> handler) where T : Avalonia.Layout.WrapLayout
    {
        var observable = obj.GetObservable(Avalonia.Layout.WrapLayout.HorizontalSpacingProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Layout.WrapLayout.VerticalSpacingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalSpacing<T>(this T obj, System.Double value) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.VerticalSpacingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalSpacing<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Layout.WrapLayout
    {
        var descriptor = Avalonia.Layout.WrapLayout.VerticalSpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalSpacing<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Layout.WrapLayout
    {
        var descriptor = Avalonia.Layout.WrapLayout.VerticalSpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindVerticalSpacing(
        this Avalonia.Layout.WrapLayout obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Layout.WrapLayout.VerticalSpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveVerticalSpacing(this Avalonia.Layout.WrapLayout obj)
    {
        return obj.GetObservable(Avalonia.Layout.WrapLayout.VerticalSpacingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Layout.WrapLayout.VerticalSpacingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVerticalSpacing<T>(this T obj, Action<Avalonia.Layout.WrapLayout, IObservable<System.Double>> handler) where T : Avalonia.Layout.WrapLayout
    {
        var observable = obj.GetObservable(Avalonia.Layout.WrapLayout.VerticalSpacingProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Layout.WrapLayout.OrientationProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Layout.WrapLayout
    {
        var descriptor = Avalonia.Layout.WrapLayout.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        IObservable<Avalonia.Layout.Orientation> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Layout.WrapLayout
    {
        var descriptor = Avalonia.Layout.WrapLayout.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOrientation(
        this Avalonia.Layout.WrapLayout obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Layout.WrapLayout.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Layout.WrapLayout obj)
    {
        return obj.GetObservable(Avalonia.Layout.WrapLayout.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientation<T>(this T obj, Action<Avalonia.Layout.WrapLayout, IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Layout.WrapLayout
    {
        var observable = obj.GetObservable(Avalonia.Layout.WrapLayout.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Horizontal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Layout.WrapLayout.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Vertical"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }
}
