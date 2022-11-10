// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.QuadraticBezierSegment"/> class property extension methods.
/// </summary>
public static partial class QuadraticBezierSegmentExtensions
{
    // Avalonia.Media.QuadraticBezierSegment.Point1Property

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.QuadraticBezierSegment.Point1Property] = value;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="binding"></param>
    /// <param name="mode"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment Point1(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point1Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="observable"></param>
    /// <param name="mode"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment Point1(
        this Avalonia.Media.QuadraticBezierSegment obj,
        IObservable<Avalonia.Point> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point1Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public static Avalonia.Data.IBinding BindPoint1(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point1Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Point> ObservePoint1(this Avalonia.Media.QuadraticBezierSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point1Property);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment OnPoint1(this Avalonia.Media.QuadraticBezierSegment obj, Action<Avalonia.Media.QuadraticBezierSegment, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point1Property);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.QuadraticBezierSegment.Point2Property

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.QuadraticBezierSegment.Point2Property] = value;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="binding"></param>
    /// <param name="mode"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment Point2(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point2Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="observable"></param>
    /// <param name="mode"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment Point2(
        this Avalonia.Media.QuadraticBezierSegment obj,
        IObservable<Avalonia.Point> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point2Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    /// <param name="priority"></param>
    /// <returns></returns>
    public static Avalonia.Data.IBinding BindPoint2(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point2Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Point> ObservePoint2(this Avalonia.Media.QuadraticBezierSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point2Property);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <returns></returns>
    public static Avalonia.Media.QuadraticBezierSegment OnPoint2(this Avalonia.Media.QuadraticBezierSegment obj, Action<Avalonia.Media.QuadraticBezierSegment, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point2Property);
        handler(obj, observable);
        return obj;
    }
}
