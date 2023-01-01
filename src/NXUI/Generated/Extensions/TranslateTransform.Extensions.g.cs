// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.TranslateTransform"/> class property extension methods.
/// </summary>
public static partial class TranslateTransformExtensions
{
    // Avalonia.Media.TranslateTransform.XProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.TranslateTransform.XProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T X<T>(this T obj, System.Double value) where T : Avalonia.Media.TranslateTransform
    {
        obj[Avalonia.Media.TranslateTransform.XProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.XProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T X<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.TranslateTransform
    {
        var descriptor = Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.XProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T X<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.TranslateTransform
    {
        var descriptor = Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.TranslateTransform.XProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.TranslateTransform.XProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindX(
        this Avalonia.Media.TranslateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.TranslateTransform.XProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveX(this Avalonia.Media.TranslateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.TranslateTransform.XProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.TranslateTransform.XProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnX<T>(this T obj, Action<Avalonia.Media.TranslateTransform, IObservable<System.Double>> handler) where T : Avalonia.Media.TranslateTransform
    {
        var observable = obj.GetObservable(Avalonia.Media.TranslateTransform.XProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.TranslateTransform.YProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.TranslateTransform.YProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Y<T>(this T obj, System.Double value) where T : Avalonia.Media.TranslateTransform
    {
        obj[Avalonia.Media.TranslateTransform.YProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.YProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Y<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.TranslateTransform
    {
        var descriptor = Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.YProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Y<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.TranslateTransform
    {
        var descriptor = Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.TranslateTransform.YProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.TranslateTransform.YProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindY(
        this Avalonia.Media.TranslateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.TranslateTransform.YProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveY(this Avalonia.Media.TranslateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.TranslateTransform.YProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.TranslateTransform.YProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnY<T>(this T obj, Action<Avalonia.Media.TranslateTransform, IObservable<System.Double>> handler) where T : Avalonia.Media.TranslateTransform
    {
        var observable = obj.GetObservable(Avalonia.Media.TranslateTransform.YProperty);
        handler(obj, observable);
        return obj;
    }
}
