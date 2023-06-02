// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.GridSplitter"/> class property extension methods.
/// </summary>
public static partial class GridSplitterExtensions
{
    // Avalonia.Controls.GridSplitter.ResizeDirectionProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T resizeDirection<T>(this T obj, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T resizeDirection<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.ResizeDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T resizeDirection<T>(
        this T obj,
        IObservable<Avalonia.Controls.GridResizeDirection> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.ResizeDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindResizeDirection(
        this Avalonia.Controls.GridSplitter obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.GridSplitter.ResizeDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.GridResizeDirection> ObserveResizeDirection(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeDirectionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnResizeDirection<T>(this T obj, Action<Avalonia.Controls.GridSplitter, IObservable<Avalonia.Controls.GridResizeDirection>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> property value to <see cref="Avalonia.Controls.GridResizeDirection.Auto"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeDirectionAuto<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = Avalonia.Controls.GridResizeDirection.Auto;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> property value to <see cref="Avalonia.Controls.GridResizeDirection.Columns"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeDirectionColumns<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = Avalonia.Controls.GridResizeDirection.Columns;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeDirectionProperty"/> property value to <see cref="Avalonia.Controls.GridResizeDirection.Rows"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeDirectionRows<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = Avalonia.Controls.GridResizeDirection.Rows;
        return obj;
    }

    // Avalonia.Controls.GridSplitter.ResizeBehaviorProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T resizeBehavior<T>(this T obj, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T resizeBehavior<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.ResizeBehaviorProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T resizeBehavior<T>(
        this T obj,
        IObservable<Avalonia.Controls.GridResizeBehavior> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.ResizeBehaviorProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindResizeBehavior(
        this Avalonia.Controls.GridSplitter obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.GridSplitter.ResizeBehaviorProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.GridResizeBehavior> ObserveResizeBehavior(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnResizeBehavior<T>(this T obj, Action<Avalonia.Controls.GridSplitter, IObservable<Avalonia.Controls.GridResizeBehavior>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> property value to <see cref="Avalonia.Controls.GridResizeBehavior.BasedOnAlignment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeBehaviorBasedOnAlignment<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.BasedOnAlignment;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> property value to <see cref="Avalonia.Controls.GridResizeBehavior.CurrentAndNext"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeBehaviorCurrentAndNext<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.CurrentAndNext;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> property value to <see cref="Avalonia.Controls.GridResizeBehavior.PreviousAndCurrent"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeBehaviorPreviousAndCurrent<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.PreviousAndCurrent;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ResizeBehaviorProperty"/> property value to <see cref="Avalonia.Controls.GridResizeBehavior.PreviousAndNext"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ResizeBehaviorPreviousAndNext<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.PreviousAndNext;
        return obj;
    }

    // Avalonia.Controls.GridSplitter.ShowsPreviewProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T showsPreview<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ShowsPreviewProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T showsPreview<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.ShowsPreviewProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T showsPreview<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.ShowsPreviewProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShowsPreview(
        this Avalonia.Controls.GridSplitter obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.GridSplitter.ShowsPreviewProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveShowsPreview(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.ShowsPreviewProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.GridSplitter.ShowsPreviewProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShowsPreview<T>(this T obj, Action<Avalonia.Controls.GridSplitter, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.ShowsPreviewProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.GridSplitter.KeyboardIncrementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T keyboardIncrement<T>(this T obj, System.Double value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.KeyboardIncrementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T keyboardIncrement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.KeyboardIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T keyboardIncrement<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.KeyboardIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindKeyboardIncrement(
        this Avalonia.Controls.GridSplitter obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.GridSplitter.KeyboardIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveKeyboardIncrement(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.GridSplitter.KeyboardIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnKeyboardIncrement<T>(this T obj, Action<Avalonia.Controls.GridSplitter, IObservable<System.Double>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.GridSplitter.DragIncrementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T dragIncrement<T>(this T obj, System.Double value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.DragIncrementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T dragIncrement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.DragIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T dragIncrement<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.DragIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDragIncrement(
        this Avalonia.Controls.GridSplitter obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.GridSplitter.DragIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveDragIncrement(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.DragIncrementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.GridSplitter.DragIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDragIncrement<T>(this T obj, Action<Avalonia.Controls.GridSplitter, IObservable<System.Double>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.DragIncrementProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.GridSplitter.PreviewContentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T previewContent<T>(this T obj, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.PreviewContentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T previewContent<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.PreviewContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T previewContent<T>(
        this T obj,
        IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.GridSplitter
    {
        var descriptor = Avalonia.Controls.GridSplitter.PreviewContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPreviewContent(
        this Avalonia.Controls.GridSplitter obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.GridSplitter.PreviewContentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> ObservePreviewContent(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.PreviewContentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.GridSplitter.PreviewContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPreviewContent<T>(this T obj, Action<Avalonia.Controls.GridSplitter, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.PreviewContentProperty);
        handler(obj, observable);
        return obj;
    }
}
