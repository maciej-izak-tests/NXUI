// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ListBoxItemExtensions
{
    // IsSelectedProperty

    public static T IsSelected<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ListBoxItem
    {
        obj[Avalonia.Controls.ListBoxItem.IsSelectedProperty] = value;
        return obj;
    }

    public static T IsSelected<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ListBoxItem
    {
        obj[Avalonia.Controls.ListBoxItem.IsSelectedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsSelected(this Avalonia.Controls.ListBoxItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ListBoxItem.IsSelectedProperty.Bind().WithMode(mode)];
    }
}
