// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.RichTextBlock"/> class property extension methods.
/// </summary>
public static partial class RichTextBlockExtensions
{
    // Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsTextSelectionEnabled<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.RichTextBlock
    {
        obj[Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsTextSelectionEnabled<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsTextSelectionEnabled<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsTextSelectionEnabled(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsTextSelectionEnabled(this Avalonia.Controls.RichTextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsTextSelectionEnabled<T>(this T obj, Action<Avalonia.Controls.RichTextBlock, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RichTextBlock.SelectionStartProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionStart<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.RichTextBlock
    {
        obj[Avalonia.Controls.RichTextBlock.SelectionStartProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionStart<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionStartProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionStart<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionStartProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectionStart(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionStartProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveSelectionStart(this Avalonia.Controls.RichTextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectionStartProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectionStart<T>(this T obj, Action<Avalonia.Controls.RichTextBlock, IObservable<System.Int32>> handler) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectionStartProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RichTextBlock.SelectionEndProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionEnd<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.RichTextBlock
    {
        obj[Avalonia.Controls.RichTextBlock.SelectionEndProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionEnd<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionEndProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionEnd<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionEndProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectionEnd(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionEndProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveSelectionEnd(this Avalonia.Controls.RichTextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectionEndProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectionEnd<T>(this T obj, Action<Avalonia.Controls.RichTextBlock, IObservable<System.Int32>> handler) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectionEndProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RichTextBlock.SelectedTextProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RichTextBlock.SelectedTextProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RichTextBlock.SelectedTextProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectedText(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectedTextProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectedTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.String> ObserveSelectedText(this Avalonia.Controls.RichTextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectedTextProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectedTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.RichTextBlock OnSelectedText(this Avalonia.Controls.RichTextBlock obj, Action<Avalonia.Controls.RichTextBlock, IObservable<System.String>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectedTextProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RichTextBlock.SelectionBrushProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.RichTextBlock
    {
        obj[Avalonia.Controls.RichTextBlock.SelectionBrushProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionBrush<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectionBrush<T>(
        this T obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectionBrush(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RichTextBlock.SelectionBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveSelectionBrush(this Avalonia.Controls.RichTextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectionBrushProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectionBrush<T>(this T obj, Action<Avalonia.Controls.RichTextBlock, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.SelectionBrushProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RichTextBlock.InlinesProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Inlines<T>(this T obj, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.RichTextBlock
    {
        obj[Avalonia.Controls.RichTextBlock.InlinesProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Inlines<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.InlinesProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Inlines<T>(
        this T obj,
        IObservable<Avalonia.Controls.Documents.InlineCollection> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RichTextBlock
    {
        var descriptor = Avalonia.Controls.RichTextBlock.InlinesProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindInlines(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RichTextBlock.InlinesProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Documents.InlineCollection> ObserveInlines(this Avalonia.Controls.RichTextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.InlinesProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnInlines<T>(this T obj, Action<Avalonia.Controls.RichTextBlock, IObservable<Avalonia.Controls.Documents.InlineCollection>> handler) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.InlinesProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RichTextBlock.CopyingToClipboardEvent

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="action"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnCopyingToClipboardHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.RichTextBlock
    {
        obj.AddHandler(Avalonia.Controls.RichTextBlock.CopyingToClipboardEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <param name="routes"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnCopyingToClipboard<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.RichTextBlock.CopyingToClipboardEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="routes"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCopyingToClipboard(
        this Avalonia.Controls.RichTextBlock obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.RichTextBlock.CopyingToClipboardEvent, routes);
    }

    // Avalonia.Controls.RichTextBlock.CopyingToClipboard

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="handler"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T OnCopyingToClipboardEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.RichTextBlock
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.CopyingToClipboard += h, 
                h => obj.CopyingToClipboard -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCopyingToClipboardEvent(this Avalonia.Controls.RichTextBlock obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.CopyingToClipboard += h, 
                h => obj.CopyingToClipboard -= h)
            .Select(x => x.EventArgs);
    }
}
