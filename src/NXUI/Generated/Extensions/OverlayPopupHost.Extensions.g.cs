// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Primitives.OverlayPopupHost"/> class property extension methods.
/// </summary>
public static partial class OverlayPopupHostExtensions
{
    // Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Transform<T>(this T obj, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost
    {
        obj[Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Transform<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.OverlayPopupHost
    {
        var descriptor = Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Transform<T>(
        this T obj,
        IObservable<Avalonia.Media.Transform> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.OverlayPopupHost
    {
        var descriptor = Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTransform(
        this Avalonia.Controls.Primitives.OverlayPopupHost obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Transform> ObserveTransform(this Avalonia.Controls.Primitives.OverlayPopupHost obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTransform<T>(this T obj, Action<Avalonia.Controls.Primitives.OverlayPopupHost, IObservable<Avalonia.Media.Transform>> handler) where T : Avalonia.Controls.Primitives.OverlayPopupHost
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty);
        handler(obj, observable);
        return obj;
    }
}
