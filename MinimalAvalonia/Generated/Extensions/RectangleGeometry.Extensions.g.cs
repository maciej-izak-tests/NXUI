// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class RectangleGeometryExtensions
{
    // RectProperty

    public static T Rect<T>(this T obj, Avalonia.Rect value) where T : Avalonia.Media.RectangleGeometry
    {
        obj[Avalonia.Media.RectangleGeometry.RectProperty] = value;
        return obj;
    }

    public static T Rect<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RectangleGeometry
    {
        obj[Avalonia.Media.RectangleGeometry.RectProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Rect(this Avalonia.Media.RectangleGeometry obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.RectangleGeometry.RectProperty.Bind().WithMode(mode)];
    }
}
