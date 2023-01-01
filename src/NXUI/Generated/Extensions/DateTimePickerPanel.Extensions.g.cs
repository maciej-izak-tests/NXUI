// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel"/> class property extension methods.
/// </summary>
public static partial class DateTimePickerPanelExtensions
{
    // Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemHeight<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemHeight<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemHeight<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemHeight(
        this Avalonia.Controls.Primitives.DateTimePickerPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveItemHeight(this Avalonia.Controls.Primitives.DateTimePickerPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemHeight<T>(this T obj, Action<Avalonia.Controls.Primitives.DateTimePickerPanel, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelType<T>(this T obj, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelType<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelType<T>(
        this T obj,
        IObservable<Avalonia.Controls.Primitives.DateTimePickerPanelType> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPanelType(
        this Avalonia.Controls.Primitives.DateTimePickerPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Primitives.DateTimePickerPanelType> ObservePanelType(this Avalonia.Controls.Primitives.DateTimePickerPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPanelType<T>(this T obj, Action<Avalonia.Controls.Primitives.DateTimePickerPanel, IObservable<Avalonia.Controls.Primitives.DateTimePickerPanelType>> handler) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> property value to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanelType.Year"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelTypeYear<T>(this T obj) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = Avalonia.Controls.Primitives.DateTimePickerPanelType.Year;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> property value to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanelType.Month"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelTypeMonth<T>(this T obj) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = Avalonia.Controls.Primitives.DateTimePickerPanelType.Month;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> property value to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanelType.Day"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelTypeDay<T>(this T obj) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = Avalonia.Controls.Primitives.DateTimePickerPanelType.Day;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> property value to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanelType.Hour"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelTypeHour<T>(this T obj) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = Avalonia.Controls.Primitives.DateTimePickerPanelType.Hour;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> property value to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanelType.Minute"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelTypeMinute<T>(this T obj) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = Avalonia.Controls.Primitives.DateTimePickerPanelType.Minute;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty"/> property value to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanelType.TimePeriod"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PanelTypeTimePeriod<T>(this T obj) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty] = Avalonia.Controls.Primitives.DateTimePickerPanelType.TimePeriod;
        return obj;
    }

    // Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemFormat<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemFormat<T>(
        this T obj,
        IObservable<System.String> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemFormat(
        this Avalonia.Controls.Primitives.DateTimePickerPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.String> ObserveItemFormat(this Avalonia.Controls.Primitives.DateTimePickerPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemFormat<T>(this T obj, Action<Avalonia.Controls.Primitives.DateTimePickerPanel, IObservable<System.String>> handler) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShouldLoop<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        obj[Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShouldLoop<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShouldLoop<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShouldLoop(
        this Avalonia.Controls.Primitives.DateTimePickerPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveShouldLoop(this Avalonia.Controls.Primitives.DateTimePickerPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShouldLoop<T>(this T obj, Action<Avalonia.Controls.Primitives.DateTimePickerPanel, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty);
        handler(obj, observable);
        return obj;
    }
}
