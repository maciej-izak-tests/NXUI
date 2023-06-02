// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.MatrixTransform"/> class property extension methods.
/// </summary>
public static partial class MatrixTransformExtensions
{
    // Avalonia.Media.MatrixTransform.MatrixProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T matrix<T>(this T obj, Avalonia.Matrix value) where T : Avalonia.Media.MatrixTransform
    {
        obj[Avalonia.Media.MatrixTransform.MatrixProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T matrix<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.MatrixTransform
    {
        var descriptor = Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T matrix<T>(
        this T obj,
        IObservable<Avalonia.Matrix> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.MatrixTransform
    {
        var descriptor = Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMatrix(
        this Avalonia.Media.MatrixTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Matrix> ObserveMatrix(this Avalonia.Media.MatrixTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.MatrixTransform.MatrixProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMatrix<T>(this T obj, Action<Avalonia.Media.MatrixTransform, IObservable<Avalonia.Matrix>> handler) where T : Avalonia.Media.MatrixTransform
    {
        var observable = obj.GetObservable(Avalonia.Media.MatrixTransform.MatrixProperty);
        handler(obj, observable);
        return obj;
    }
}
