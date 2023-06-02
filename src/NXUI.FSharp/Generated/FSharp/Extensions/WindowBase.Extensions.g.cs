// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.WindowBase"/> class property extension methods.
/// </summary>
public static partial class WindowBaseExtensions
{
    // Avalonia.Controls.WindowBase.IsActiveProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.WindowBase.IsActiveProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.WindowBase.IsActiveProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsActive(
        this Avalonia.Controls.WindowBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.WindowBase.IsActiveProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.WindowBase.IsActiveProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsActive(this Avalonia.Controls.WindowBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.WindowBase.IsActiveProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.WindowBase.IsActiveProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.WindowBase OnIsActive(this Avalonia.Controls.WindowBase obj, Action<Avalonia.Controls.WindowBase, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.WindowBase.IsActiveProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.WindowBase.OwnerProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.WindowBase.OwnerProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.WindowBase.OwnerProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOwner(
        this Avalonia.Controls.WindowBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.WindowBase.OwnerProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.WindowBase.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.WindowBase> ObserveOwner(this Avalonia.Controls.WindowBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.WindowBase.OwnerProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.WindowBase.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.WindowBase OnOwner(this Avalonia.Controls.WindowBase obj, Action<Avalonia.Controls.WindowBase, IObservable<Avalonia.Controls.WindowBase>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.WindowBase.OwnerProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.WindowBase.TopmostProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T topmost<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.TopmostProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T topmost<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.WindowBase
    {
        var descriptor = Avalonia.Controls.WindowBase.TopmostProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T topmost<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.WindowBase
    {
        var descriptor = Avalonia.Controls.WindowBase.TopmostProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTopmost(
        this Avalonia.Controls.WindowBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.WindowBase.TopmostProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveTopmost(this Avalonia.Controls.WindowBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.WindowBase.TopmostProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.WindowBase.TopmostProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTopmost<T>(this T obj, Action<Avalonia.Controls.WindowBase, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.WindowBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.WindowBase.TopmostProperty);
        handler(obj, observable);
        return obj;
    }
}
