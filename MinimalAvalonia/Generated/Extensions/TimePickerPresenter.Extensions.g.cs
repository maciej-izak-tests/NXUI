// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TimePickerPresenterExtensions
{
    // MinuteIncrementProperty

    public static T MinuteIncrement<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty] = value;
        return obj;
    }

    public static T MinuteIncrement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding MinuteIncrement(this Avalonia.Controls.TimePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty.Bind().WithMode(mode)];
    }

    // ClockIdentifierProperty

    public static T ClockIdentifier<T>(this T obj, System.String value) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty] = value;
        return obj;
    }

    public static T ClockIdentifier<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ClockIdentifier(this Avalonia.Controls.TimePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty.Bind().WithMode(mode)];
    }

    // TimeProperty

    public static T Time<T>(this T obj, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.TimeProperty] = value;
        return obj;
    }

    public static T Time<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.TimeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Time(this Avalonia.Controls.TimePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TimePickerPresenter.TimeProperty.Bind().WithMode(mode)];
    }
}
