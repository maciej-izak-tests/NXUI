// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ItemsControl"/> class property extension methods.
/// </summary>
public static partial class ItemsControlExtensions
{
    // Avalonia.Controls.ItemsControl.ItemContainerThemeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemContainerTheme<T>(this T obj, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemContainerThemeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemContainerTheme<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemContainerThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemContainerTheme<T>(
        this T obj,
        IObservable<Avalonia.Styling.ControlTheme> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemContainerThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemContainerTheme(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemContainerThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Styling.ControlTheme> ObserveItemContainerTheme(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemContainerTheme<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Styling.ControlTheme>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemCountProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemCount(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemCountProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveItemCount(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemCountProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.ItemsControl OnItemCount(this Avalonia.Controls.ItemsControl obj, Action<Avalonia.Controls.ItemsControl, IObservable<System.Int32>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemCountProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemsPanelProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(this T obj, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemsPanelProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(
        this T obj,
        IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemsPanel(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> ObserveItemsPanel(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsPanelProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemsPanel<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsPanelProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemsSourceProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsSource<T>(this T obj, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemsSourceProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsSource<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsSourceProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsSource<T>(
        this T obj,
        IObservable<System.Collections.IEnumerable> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsSourceProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemsSource(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsSourceProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Collections.IEnumerable> ObserveItemsSource(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsSourceProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsSourceProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemsSource<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<System.Collections.IEnumerable>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsSourceProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemTemplate(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveItemTemplate(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemTemplate<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DisplayMemberBinding<T>(this T obj, Avalonia.Data.IBinding value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DisplayMemberBinding<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DisplayMemberBinding<T>(
        this T obj,
        IObservable<Avalonia.Data.IBinding> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDisplayMemberBinding(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Data.IBinding> ObserveDisplayMemberBinding(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDisplayMemberBinding<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Data.IBinding>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreHorizontalSnapPointsRegular<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreHorizontalSnapPointsRegular<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreHorizontalSnapPointsRegular<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAreHorizontalSnapPointsRegular(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAreHorizontalSnapPointsRegular(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAreHorizontalSnapPointsRegular<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreVerticalSnapPointsRegular<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreVerticalSnapPointsRegular<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreVerticalSnapPointsRegular<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAreVerticalSnapPointsRegular(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAreVerticalSnapPointsRegular(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAreVerticalSnapPointsRegular<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty);
        handler(obj, observable);
        return obj;
    }
}
