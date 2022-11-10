// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.ToolTip"/> class property extension methods.
/// </summary>
public static partial class ToolTipExtensions
{
    // Avalonia.Controls.ToolTip.TipProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.TipProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Tip<T>(this T obj, System.Object value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.TipProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.TipProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Tip<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.TipProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.TipProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Tip<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.TipProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToolTip.TipProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToolTip.TipProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTip(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToolTip.TipProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToolTip.TipProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveTip(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToolTip.TipProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToolTip.TipProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTip<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Object>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToolTip.TipProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToolTip.IsOpenProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.IsOpenProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsOpen<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.IsOpenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsOpen<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.IsOpenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsOpen(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToolTip.IsOpenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsOpen(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToolTip.IsOpenProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToolTip.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsOpen<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToolTip.IsOpenProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToolTip.PlacementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Placement<T>(this T obj, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Placement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.PlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Placement<T>(
        this T obj,
        IObservable<Avalonia.Controls.PlacementMode> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.PlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPlacement(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToolTip.PlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.PlacementMode> ObservePlacement(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToolTip.PlacementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPlacement<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.PlacementMode>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToolTip.PlacementProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> property value to <see cref="Avalonia.Controls.PlacementMode.Pointer"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementPointer<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Pointer;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> property value to <see cref="Avalonia.Controls.PlacementMode.Bottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementBottom<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Bottom;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> property value to <see cref="Avalonia.Controls.PlacementMode.Right"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementRight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Right;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> property value to <see cref="Avalonia.Controls.PlacementMode.Left"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementLeft<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Left;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> property value to <see cref="Avalonia.Controls.PlacementMode.Top"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementTop<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Top;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.PlacementProperty"/> property value to <see cref="Avalonia.Controls.PlacementMode.AnchorAndGravity"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementAnchorAndGravity<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.AnchorAndGravity;
        return obj;
    }

    // Avalonia.Controls.ToolTip.HorizontalOffsetProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.HorizontalOffsetProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalOffset<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.HorizontalOffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalOffset<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.HorizontalOffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHorizontalOffset(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToolTip.HorizontalOffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveHorizontalOffset(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToolTip.HorizontalOffsetProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToolTip.HorizontalOffsetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHorizontalOffset<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Double>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToolTip.HorizontalOffsetProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToolTip.VerticalOffsetProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.VerticalOffsetProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalOffset<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.VerticalOffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalOffset<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.VerticalOffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindVerticalOffset(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToolTip.VerticalOffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveVerticalOffset(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToolTip.VerticalOffsetProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToolTip.VerticalOffsetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVerticalOffset<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Double>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToolTip.VerticalOffsetProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToolTip.ShowDelayProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowDelay<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.ShowDelayProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowDelay<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.ShowDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowDelay<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.ToolTip.ShowDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShowDelay(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToolTip.ShowDelayProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveShowDelay(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToolTip.ShowDelayProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToolTip.ShowDelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShowDelay<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Int32>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToolTip.ShowDelayProperty);
        handler(obj, observable);
        return obj;
    }
}
