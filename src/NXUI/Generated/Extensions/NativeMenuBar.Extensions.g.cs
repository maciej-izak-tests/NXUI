// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.NativeMenuBar"/> class property extension methods.
/// </summary>
public static partial class NativeMenuBarExtensions
{
    // Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T EnableMenuItemClickForwarding<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T EnableMenuItemClickForwarding<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.MenuItem
    {
        var descriptor = Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T EnableMenuItemClickForwarding<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.MenuItem
    {
        var descriptor = Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindEnableMenuItemClickForwarding(
        this Avalonia.Controls.MenuItem obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveEnableMenuItemClickForwarding(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnEnableMenuItemClickForwarding<T>(this T obj, Action<Avalonia.Controls.MenuItem, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.MenuItem
    {
        var observable = obj.GetObservable(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty);
        handler(obj, observable);
        return obj;
    }
}
