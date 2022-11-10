// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.Pen"/> class style setters extension methods.
/// </summary>
public static partial class PenSetters
{
    // Avalonia.Media.Pen.BrushProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.BrushProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenBrush(this Style style, Avalonia.Media.IBrush value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.BrushProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.BrushProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenBrush(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.BrushProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.BrushProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenBrush(this Style style, IObservable<Avalonia.Media.IBrush> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.BrushProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.BrushProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenBrush(this KeyFrame keyFrame, Avalonia.Media.IBrush value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.BrushProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.BrushProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenBrush(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.BrushProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.BrushProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenBrush(this KeyFrame keyFrame, IObservable<Avalonia.Media.IBrush> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.BrushProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.Pen.ThicknessProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.ThicknessProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenThickness(this Style style, System.Double value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.ThicknessProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.ThicknessProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenThickness(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.ThicknessProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.ThicknessProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenThickness(this Style style, IObservable<System.Double> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.ThicknessProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.ThicknessProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenThickness(this KeyFrame keyFrame, System.Double value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.ThicknessProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.ThicknessProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenThickness(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.ThicknessProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.ThicknessProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenThickness(this KeyFrame keyFrame, IObservable<System.Double> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.ThicknessProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.Pen.DashStyleProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.DashStyleProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenDashStyle(this Style style, Avalonia.Media.IDashStyle value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.DashStyleProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.DashStyleProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenDashStyle(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.DashStyleProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.DashStyleProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenDashStyle(this Style style, IObservable<Avalonia.Media.IDashStyle> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.DashStyleProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.DashStyleProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenDashStyle(this KeyFrame keyFrame, Avalonia.Media.IDashStyle value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.DashStyleProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.DashStyleProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenDashStyle(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.DashStyleProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.DashStyleProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenDashStyle(this KeyFrame keyFrame, IObservable<Avalonia.Media.IDashStyle> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.DashStyleProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.Pen.LineCapProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.LineCapProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenLineCap(this Style style, Avalonia.Media.PenLineCap value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.LineCapProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.LineCapProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenLineCap(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.LineCapProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.LineCapProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenLineCap(this Style style, IObservable<Avalonia.Media.PenLineCap> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.LineCapProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.LineCapProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenLineCap(this KeyFrame keyFrame, Avalonia.Media.PenLineCap value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.LineCapProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.LineCapProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenLineCap(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.LineCapProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.LineCapProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenLineCap(this KeyFrame keyFrame, IObservable<Avalonia.Media.PenLineCap> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.LineCapProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.Pen.LineJoinProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.LineJoinProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenLineJoin(this Style style, Avalonia.Media.PenLineJoin value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.LineJoinProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.LineJoinProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenLineJoin(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.LineJoinProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.LineJoinProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenLineJoin(this Style style, IObservable<Avalonia.Media.PenLineJoin> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.LineJoinProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.LineJoinProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenLineJoin(this KeyFrame keyFrame, Avalonia.Media.PenLineJoin value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.LineJoinProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.LineJoinProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenLineJoin(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.LineJoinProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.LineJoinProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenLineJoin(this KeyFrame keyFrame, IObservable<Avalonia.Media.PenLineJoin> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.LineJoinProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.Pen.MiterLimitProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.MiterLimitProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenMiterLimit(this Style style, System.Double value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.MiterLimitProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.MiterLimitProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenMiterLimit(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.MiterLimitProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Pen.MiterLimitProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPenMiterLimit(this Style style, IObservable<System.Double> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Pen.MiterLimitProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.MiterLimitProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenMiterLimit(this KeyFrame keyFrame, System.Double value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.MiterLimitProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.MiterLimitProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenMiterLimit(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.MiterLimitProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Pen.MiterLimitProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPenMiterLimit(this KeyFrame keyFrame, IObservable<System.Double> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Pen.MiterLimitProperty, observable.ToBinding()));
        return keyFrame;
    }
}
