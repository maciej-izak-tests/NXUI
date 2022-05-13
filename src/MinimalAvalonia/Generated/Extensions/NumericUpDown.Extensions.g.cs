// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class NumericUpDownExtensions
{
    // AllowSpinProperty

    public static T AllowSpin<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.AllowSpinProperty] = value;
        return obj;
    }

    public static T AllowSpin<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.AllowSpinProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AllowSpin<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.AllowSpinProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAllowSpin(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.AllowSpinProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveAllowSpin(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.AllowSpinProperty);
    }

    public static T OnAllowSpin<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.AllowSpinProperty);
        handler(observable);
        return obj;
    }

    // ButtonSpinnerLocationProperty

    public static T ButtonSpinnerLocation<T>(this T obj, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty] = value;
        return obj;
    }

    public static T ButtonSpinnerLocation<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ButtonSpinnerLocation<T>(this T obj, IObservable<Avalonia.Controls.Location> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindButtonSpinnerLocation(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Location> ObserveButtonSpinnerLocation(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty);
    }

    public static T OnButtonSpinnerLocation<T>(this T obj, Action<IObservable<Avalonia.Controls.Location>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty);
        handler(observable);
        return obj;
    }

    public static T ButtonSpinnerLocationLeft<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty] = Avalonia.Controls.Location.Left;
        return obj;
    }

    public static T ButtonSpinnerLocationRight<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty] = Avalonia.Controls.Location.Right;
        return obj;
    }

    // ShowButtonSpinnerProperty

    public static T ShowButtonSpinner<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty] = value;
        return obj;
    }

    public static T ShowButtonSpinner<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ShowButtonSpinner<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindShowButtonSpinner(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveShowButtonSpinner(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty);
    }

    public static T OnShowButtonSpinner<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty);
        handler(observable);
        return obj;
    }

    // ClipValueToMinMaxProperty

    public static T ClipValueToMinMax<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty] = value;
        return obj;
    }

    public static T ClipValueToMinMax<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ClipValueToMinMax<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindClipValueToMinMax(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveClipValueToMinMax(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty);
    }

    public static T OnClipValueToMinMax<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty);
        handler(observable);
        return obj;
    }

    // NumberFormatProperty

    public static T NumberFormat<T>(this T obj, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.NumberFormatProperty] = value;
        return obj;
    }

    public static T NumberFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.NumberFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T NumberFormat<T>(this T obj, IObservable<System.Globalization.NumberFormatInfo> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.NumberFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindNumberFormat(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.NumberFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Globalization.NumberFormatInfo> ObserveNumberFormat(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.NumberFormatProperty);
    }

    public static T OnNumberFormat<T>(this T obj, Action<IObservable<System.Globalization.NumberFormatInfo>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.NumberFormatProperty);
        handler(observable);
        return obj;
    }

    // FormatStringProperty

    public static T FormatString<T>(this T obj, System.String value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.FormatStringProperty] = value;
        return obj;
    }

    public static T FormatString<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.FormatStringProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FormatString<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.FormatStringProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFormatString(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.FormatStringProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveFormatString(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.FormatStringProperty);
    }

    public static T OnFormatString<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.FormatStringProperty);
        handler(observable);
        return obj;
    }

    // IncrementProperty

    public static T Increment<T>(this T obj, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.IncrementProperty] = value;
        return obj;
    }

    public static T Increment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.IncrementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Increment<T>(this T obj, IObservable<System.Decimal> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.IncrementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIncrement(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.IncrementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Decimal> ObserveIncrement(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.IncrementProperty);
    }

    public static T OnIncrement<T>(this T obj, Action<IObservable<System.Decimal>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.IncrementProperty);
        handler(observable);
        return obj;
    }

    // IsReadOnlyProperty

    public static T IsReadOnly<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.IsReadOnlyProperty] = value;
        return obj;
    }

    public static T IsReadOnly<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.IsReadOnlyProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsReadOnly<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.IsReadOnlyProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsReadOnly(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.IsReadOnlyProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsReadOnly(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty);
    }

    public static T OnIsReadOnly<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty);
        handler(observable);
        return obj;
    }

    // MaximumProperty

    public static T Maximum<T>(this T obj, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.MaximumProperty] = value;
        return obj;
    }

    public static T Maximum<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.MaximumProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Maximum<T>(this T obj, IObservable<System.Decimal> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.MaximumProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaximum(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.MaximumProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Decimal> ObserveMaximum(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.MaximumProperty);
    }

    public static T OnMaximum<T>(this T obj, Action<IObservable<System.Decimal>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.MaximumProperty);
        handler(observable);
        return obj;
    }

    // MinimumProperty

    public static T Minimum<T>(this T obj, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.MinimumProperty] = value;
        return obj;
    }

    public static T Minimum<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.MinimumProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Minimum<T>(this T obj, IObservable<System.Decimal> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.MinimumProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinimum(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.MinimumProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Decimal> ObserveMinimum(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.MinimumProperty);
    }

    public static T OnMinimum<T>(this T obj, Action<IObservable<System.Decimal>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.MinimumProperty);
        handler(observable);
        return obj;
    }

    // ParsingNumberStyleProperty

    public static T ParsingNumberStyle<T>(this T obj, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = value;
        return obj;
    }

    public static T ParsingNumberStyle<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ParsingNumberStyle<T>(this T obj, IObservable<System.Globalization.NumberStyles> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindParsingNumberStyle(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Globalization.NumberStyles> ObserveParsingNumberStyle(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty);
    }

    public static T OnParsingNumberStyle<T>(this T obj, Action<IObservable<System.Globalization.NumberStyles>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty);
        handler(observable);
        return obj;
    }

    public static T ParsingNumberStyleNone<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.None;
        return obj;
    }

    public static T ParsingNumberStyleAllowLeadingWhite<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowLeadingWhite;
        return obj;
    }

    public static T ParsingNumberStyleAllowTrailingWhite<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowTrailingWhite;
        return obj;
    }

    public static T ParsingNumberStyleAllowLeadingSign<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowLeadingSign;
        return obj;
    }

    public static T ParsingNumberStyleInteger<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.Integer;
        return obj;
    }

    public static T ParsingNumberStyleAllowTrailingSign<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowTrailingSign;
        return obj;
    }

    public static T ParsingNumberStyleAllowParentheses<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowParentheses;
        return obj;
    }

    public static T ParsingNumberStyleAllowDecimalPoint<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowDecimalPoint;
        return obj;
    }

    public static T ParsingNumberStyleAllowThousands<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowThousands;
        return obj;
    }

    public static T ParsingNumberStyleNumber<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.Number;
        return obj;
    }

    public static T ParsingNumberStyleAllowExponent<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowExponent;
        return obj;
    }

    public static T ParsingNumberStyleFloat<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.Float;
        return obj;
    }

    public static T ParsingNumberStyleAllowCurrencySymbol<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowCurrencySymbol;
        return obj;
    }

    public static T ParsingNumberStyleCurrency<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.Currency;
        return obj;
    }

    public static T ParsingNumberStyleAny<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.Any;
        return obj;
    }

    public static T ParsingNumberStyleAllowHexSpecifier<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.AllowHexSpecifier;
        return obj;
    }

    public static T ParsingNumberStyleHexNumber<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty] = System.Globalization.NumberStyles.HexNumber;
        return obj;
    }

    // TextProperty

    public static T Text<T>(this T obj, System.String value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Text<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.TextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindText(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.TextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveText(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.TextProperty);
    }

    public static T OnText<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.TextProperty);
        handler(observable);
        return obj;
    }

    // ValueProperty

    public static T Value<T>(this T obj, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ValueProperty] = value;
        return obj;
    }

    public static T Value<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ValueProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Value<T>(this T obj, IObservable<System.Decimal> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.ValueProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindValue(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.ValueProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Decimal> ObserveValue(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.ValueProperty);
    }

    public static T OnValue<T>(this T obj, Action<IObservable<System.Decimal>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.ValueProperty);
        handler(observable);
        return obj;
    }

    // WatermarkProperty

    public static T Watermark<T>(this T obj, System.String value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.WatermarkProperty] = value;
        return obj;
    }

    public static T Watermark<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.WatermarkProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Watermark<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.WatermarkProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindWatermark(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.WatermarkProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveWatermark(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.WatermarkProperty);
    }

    public static T OnWatermark<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.WatermarkProperty);
        handler(observable);
        return obj;
    }

    // HorizontalContentAlignmentProperty

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.HorizontalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHorizontalContentAlignment(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.HorizontalAlignment> ObserveHorizontalContentAlignment(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty);
    }

    public static T OnHorizontalContentAlignment<T>(this T obj, Action<IObservable<Avalonia.Layout.HorizontalAlignment>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty);
        handler(observable);
        return obj;
    }

    public static T HorizontalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    public static T HorizontalContentAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    public static T HorizontalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    public static T HorizontalContentAlignmentRight<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // VerticalContentAlignmentProperty

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.VerticalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindVerticalContentAlignment(this Avalonia.Controls.NumericUpDown obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.VerticalAlignment> ObserveVerticalContentAlignment(this Avalonia.Controls.NumericUpDown obj)
    {
        return obj.GetObservable(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty);
    }

    public static T OnVerticalContentAlignment<T>(this T obj, Action<IObservable<Avalonia.Layout.VerticalAlignment>> handler) where T : Avalonia.Controls.NumericUpDown
    {
        var observable = obj.GetObservable(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty);
        handler(observable);
        return obj;
    }

    public static T VerticalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    public static T VerticalContentAlignmentTop<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    public static T VerticalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    public static T VerticalContentAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.NumericUpDown
    {
        obj[Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }
}
