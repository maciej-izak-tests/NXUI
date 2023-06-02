// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.ScrollBar"/> class property extension methods.
/// </summary>
public static partial class ScrollBarExtensions
{
    // Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T viewportSize<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T viewportSize<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T viewportSize<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindViewportSize(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveViewportSize(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnViewportSize<T>(this T obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T visibility<T>(this T obj, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T visibility<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T visibility<T>(
        this T obj,
        IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindVisibility(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility> ObserveVisibility(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVisibility<T>(this T obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<Avalonia.Controls.Primitives.ScrollBarVisibility>> handler) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> property value to <see cref="Avalonia.Controls.Primitives.ScrollBarVisibility.Disabled"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VisibilityDisabled<T>(this T obj) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty] = Avalonia.Controls.Primitives.ScrollBarVisibility.Disabled;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> property value to <see cref="Avalonia.Controls.Primitives.ScrollBarVisibility.Auto"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VisibilityAuto<T>(this T obj) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty] = Avalonia.Controls.Primitives.ScrollBarVisibility.Auto;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> property value to <see cref="Avalonia.Controls.Primitives.ScrollBarVisibility.Hidden"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VisibilityHidden<T>(this T obj) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty] = Avalonia.Controls.Primitives.ScrollBarVisibility.Hidden;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty"/> property value to <see cref="Avalonia.Controls.Primitives.ScrollBarVisibility.Visible"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VisibilityVisible<T>(this T obj) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty] = Avalonia.Controls.Primitives.ScrollBarVisibility.Visible;
        return obj;
    }

    // Avalonia.Controls.Primitives.ScrollBar.OrientationProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.OrientationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T orientation<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T orientation<T>(
        this T obj,
        IObservable<Avalonia.Layout.Orientation> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOrientation(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientation<T>(this T obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Horizontal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Vertical"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }

    // Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsExpanded(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsExpanded(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.ScrollBar OnIsExpanded(this Avalonia.Controls.Primitives.ScrollBar obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T allowAutoHide<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T allowAutoHide<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T allowAutoHide<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAllowAutoHide(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAllowAutoHide(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAllowAutoHide<T>(this T obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T hideDelay<T>(this T obj, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T hideDelay<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T hideDelay<T>(
        this T obj,
        IObservable<System.TimeSpan> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHideDelay(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.TimeSpan> ObserveHideDelay(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHideDelay<T>(this T obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<System.TimeSpan>> handler) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T showDelay<T>(this T obj, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        obj[Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T showDelay<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T showDelay<T>(
        this T obj,
        IObservable<System.TimeSpan> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShowDelay(
        this Avalonia.Controls.Primitives.ScrollBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.TimeSpan> ObserveShowDelay(this Avalonia.Controls.Primitives.ScrollBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShowDelay<T>(this T obj, Action<Avalonia.Controls.Primitives.ScrollBar, IObservable<System.TimeSpan>> handler) where T : Avalonia.Controls.Primitives.ScrollBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty);
        handler(obj, observable);
        return obj;
    }
}
