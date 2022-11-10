// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.ToggleSwitch"/> class property extension methods.
/// </summary>
public static partial class ToggleSwitchExtensions
{
    // Avalonia.Controls.ToggleSwitch.OffContentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OffContent<T>(this T obj, System.Object value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OffContentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OffContent<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OffContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OffContent<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OffContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOffContent(
        this Avalonia.Controls.ToggleSwitch obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OffContentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveOffContent(this Avalonia.Controls.ToggleSwitch obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToggleSwitch.OffContentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OffContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOffContent<T>(this T obj, Action<Avalonia.Controls.ToggleSwitch, IObservable<System.Object>> handler) where T : Avalonia.Controls.ToggleSwitch
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToggleSwitch.OffContentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OffContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OffContentTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OffContentTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOffContentTemplate(
        this Avalonia.Controls.ToggleSwitch obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveOffContentTemplate(this Avalonia.Controls.ToggleSwitch obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOffContentTemplate<T>(this T obj, Action<Avalonia.Controls.ToggleSwitch, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.ToggleSwitch
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToggleSwitch.OnContentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContent<T>(this T obj, System.Object value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OnContentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContent<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OnContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContent<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OnContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOnContent(
        this Avalonia.Controls.ToggleSwitch obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OnContentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveOnContent(this Avalonia.Controls.ToggleSwitch obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToggleSwitch.OnContentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OnContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOnContent<T>(this T obj, Action<Avalonia.Controls.ToggleSwitch, IObservable<System.Object>> handler) where T : Avalonia.Controls.ToggleSwitch
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToggleSwitch.OnContentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSwitch
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOnContentTemplate(
        this Avalonia.Controls.ToggleSwitch obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveOnContentTemplate(this Avalonia.Controls.ToggleSwitch obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOnContentTemplate<T>(this T obj, Action<Avalonia.Controls.ToggleSwitch, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.ToggleSwitch
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }
}
