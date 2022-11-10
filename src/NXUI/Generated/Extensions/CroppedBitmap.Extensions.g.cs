// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.Imaging.CroppedBitmap"/> class property extension methods.
/// </summary>
public static partial class CroppedBitmapExtensions
{
    // Avalonia.Media.Imaging.CroppedBitmap.SourceProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Source<T>(this T obj, Avalonia.Media.IImage value) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        obj[Avalonia.Media.Imaging.CroppedBitmap.SourceProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Source<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        var descriptor = Avalonia.Media.Imaging.CroppedBitmap.SourceProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Source<T>(
        this T obj,
        IObservable<Avalonia.Media.IImage> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        var descriptor = Avalonia.Media.Imaging.CroppedBitmap.SourceProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSource(
        this Avalonia.Media.Imaging.CroppedBitmap obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Imaging.CroppedBitmap.SourceProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IImage> ObserveSource(this Avalonia.Media.Imaging.CroppedBitmap obj)
    {
        return obj.GetObservable(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSource<T>(this T obj, Action<Avalonia.Media.Imaging.CroppedBitmap, IObservable<Avalonia.Media.IImage>> handler) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        var observable = obj.GetObservable(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SourceRect<T>(this T obj, Avalonia.PixelRect value) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        obj[Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SourceRect<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        var descriptor = Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SourceRect<T>(
        this T obj,
        IObservable<Avalonia.PixelRect> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        var descriptor = Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSourceRect(
        this Avalonia.Media.Imaging.CroppedBitmap obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.PixelRect> ObserveSourceRect(this Avalonia.Media.Imaging.CroppedBitmap obj)
    {
        return obj.GetObservable(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSourceRect<T>(this T obj, Action<Avalonia.Media.Imaging.CroppedBitmap, IObservable<Avalonia.PixelRect>> handler) where T : Avalonia.Media.Imaging.CroppedBitmap
    {
        var observable = obj.GetObservable(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty);
        handler(obj, observable);
        return obj;
    }
}
