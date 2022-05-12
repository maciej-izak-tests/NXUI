// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ToggleSwitchExtensions
{
    // OffContentProperty

    public static T OffContent<T>(this T obj, System.Object value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OffContentProperty] = value;
        return obj;
    }

    public static T OffContent<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OffContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OffContent(this Avalonia.Controls.ToggleSwitch obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToggleSwitch.OffContentProperty.Bind().WithMode(mode)];
    }

    // OffContentTemplateProperty

    public static T OffContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty] = value;
        return obj;
    }

    public static T OffContentTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OffContentTemplate(this Avalonia.Controls.ToggleSwitch obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty.Bind().WithMode(mode)];
    }

    // OnContentProperty

    public static T OnContent<T>(this T obj, System.Object value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OnContentProperty] = value;
        return obj;
    }

    public static T OnContent<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OnContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OnContent(this Avalonia.Controls.ToggleSwitch obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToggleSwitch.OnContentProperty.Bind().WithMode(mode)];
    }

    // OnContentTemplateProperty

    public static T OnContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty] = value;
        return obj;
    }

    public static T OnContentTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ToggleSwitch
    {
        obj[Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OnContentTemplate(this Avalonia.Controls.ToggleSwitch obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty.Bind().WithMode(mode)];
    }
}
