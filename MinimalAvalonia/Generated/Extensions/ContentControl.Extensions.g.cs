// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ContentControlExtensions
{
    // ContentProperty

    public static T Content<T>(this T obj, System.Object value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentProperty] = value;
        return obj;
    }

    public static T Content<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Content(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode)];
    }

    // ContentTemplateProperty

    public static T ContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentTemplateProperty] = value;
        return obj;
    }

    public static T ContentTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ContentTemplate(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode)];
    }

    // HorizontalContentAlignmentProperty

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding HorizontalContentAlignment(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static T HorizontalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    public static T HorizontalContentAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    public static T HorizontalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    public static T HorizontalContentAlignmentRight<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // VerticalContentAlignmentProperty

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding VerticalContentAlignment(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static T VerticalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    public static T VerticalContentAlignmentTop<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    public static T VerticalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    public static T VerticalContentAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }
}
