// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class WrapPanelExtensions
{
    // OrientationProperty

    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.OrientationProperty] = value;
        return obj;
    }

    public static T Orientation<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.OrientationProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Orientation(this Avalonia.Controls.WrapPanel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.WrapPanel.OrientationProperty.Bind().WithMode(mode)];
    }

    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }

    // ItemWidthProperty

    public static T ItemWidth<T>(this T obj, System.Double value) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.ItemWidthProperty] = value;
        return obj;
    }

    public static T ItemWidth<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.ItemWidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ItemWidth(this Avalonia.Controls.WrapPanel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.WrapPanel.ItemWidthProperty.Bind().WithMode(mode)];
    }

    // ItemHeightProperty

    public static T ItemHeight<T>(this T obj, System.Double value) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.ItemHeightProperty] = value;
        return obj;
    }

    public static T ItemHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WrapPanel
    {
        obj[Avalonia.Controls.WrapPanel.ItemHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ItemHeight(this Avalonia.Controls.WrapPanel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.WrapPanel.ItemHeightProperty.Bind().WithMode(mode)];
    }
}
