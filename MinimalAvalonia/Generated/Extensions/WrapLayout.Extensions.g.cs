// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class WrapLayoutExtensions
{
    // HorizontalSpacingProperty

    public static T HorizontalSpacing<T>(this T obj, System.Double value) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.HorizontalSpacingProperty] = value;
        return obj;
    }

    public static T HorizontalSpacing<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.HorizontalSpacingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding HorizontalSpacing(this Avalonia.Layout.WrapLayout obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.WrapLayout.HorizontalSpacingProperty.Bind().WithMode(mode)];
    }

    // VerticalSpacingProperty

    public static T VerticalSpacing<T>(this T obj, System.Double value) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.VerticalSpacingProperty] = value;
        return obj;
    }

    public static T VerticalSpacing<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.VerticalSpacingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding VerticalSpacing(this Avalonia.Layout.WrapLayout obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.WrapLayout.VerticalSpacingProperty.Bind().WithMode(mode)];
    }

    // OrientationProperty

    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty] = value;
        return obj;
    }

    public static T Orientation<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Orientation(this Avalonia.Layout.WrapLayout obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.WrapLayout.OrientationProperty.Bind().WithMode(mode)];
    }

    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Layout.WrapLayout
    {
        obj[Avalonia.Layout.WrapLayout.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }
}
