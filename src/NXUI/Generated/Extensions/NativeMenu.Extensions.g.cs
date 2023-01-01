// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.NativeMenu"/> class property extension methods.
/// </summary>
public static partial class NativeMenuExtensions
{
    // Avalonia.Controls.NativeMenu.ParentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Parent<T>(this T obj, Avalonia.Controls.NativeMenuItem value) where T : Avalonia.Controls.NativeMenu
    {
        obj[Avalonia.Controls.NativeMenu.ParentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Parent<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.NativeMenu
    {
        var descriptor = Avalonia.Controls.NativeMenu.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Parent<T>(
        this T obj,
        IObservable<Avalonia.Controls.NativeMenuItem> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.NativeMenu
    {
        var descriptor = Avalonia.Controls.NativeMenu.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindParent(
        this Avalonia.Controls.NativeMenu obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.NativeMenu.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.NativeMenuItem> ObserveParent(this Avalonia.Controls.NativeMenu obj)
    {
        return obj.GetObservable(Avalonia.Controls.NativeMenu.ParentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnParent<T>(this T obj, Action<Avalonia.Controls.NativeMenu, IObservable<Avalonia.Controls.NativeMenuItem>> handler) where T : Avalonia.Controls.NativeMenu
    {
        var observable = obj.GetObservable(Avalonia.Controls.NativeMenu.ParentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsNativeMenuExported<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsNativeMenuExported<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsNativeMenuExported<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsNativeMenuExported(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsNativeMenuExported(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsNativeMenuExported<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.NativeMenu.MenuProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Menu<T>(this T obj, Avalonia.Controls.NativeMenu value) where T : Avalonia.AvaloniaObject
    {
        obj[Avalonia.Controls.NativeMenu.MenuProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Menu<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.AvaloniaObject
    {
        var descriptor = Avalonia.Controls.NativeMenu.MenuProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Menu<T>(
        this T obj,
        IObservable<Avalonia.Controls.NativeMenu> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.AvaloniaObject
    {
        var descriptor = Avalonia.Controls.NativeMenu.MenuProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMenu(
        this Avalonia.AvaloniaObject obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.NativeMenu.MenuProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.NativeMenu> ObserveMenu(this Avalonia.AvaloniaObject obj)
    {
        return obj.GetObservable(Avalonia.Controls.NativeMenu.MenuProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMenu<T>(this T obj, Action<Avalonia.AvaloniaObject, IObservable<Avalonia.Controls.NativeMenu>> handler) where T : Avalonia.AvaloniaObject
    {
        var observable = obj.GetObservable(Avalonia.Controls.NativeMenu.MenuProperty);
        handler(obj, observable);
        return obj;
    }
}
