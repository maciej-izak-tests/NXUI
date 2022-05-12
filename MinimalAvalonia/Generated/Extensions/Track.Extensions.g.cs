// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TrackExtensions
{
    // MinimumProperty

    public static T Minimum<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.MinimumProperty] = value;
        return obj;
    }

    public static T Minimum<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.MinimumProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Minimum(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.MinimumProperty.Bind().WithMode(mode)];
    }

    // MaximumProperty

    public static T Maximum<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.MaximumProperty] = value;
        return obj;
    }

    public static T Maximum<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.MaximumProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Maximum(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.MaximumProperty.Bind().WithMode(mode)];
    }

    // ValueProperty

    public static T Value<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.ValueProperty] = value;
        return obj;
    }

    public static T Value<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.ValueProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Value(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.ValueProperty.Bind().WithMode(mode)];
    }

    // ThumbProperty

    public static T Thumb<T>(this T obj, Avalonia.Controls.Primitives.Thumb value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.ThumbProperty] = value;
        return obj;
    }

    public static T Thumb<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.ThumbProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Thumb(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.ThumbProperty.Bind().WithMode(mode)];
    }

    // IncreaseButtonProperty

    public static T IncreaseButton<T>(this T obj, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.IncreaseButtonProperty] = value;
        return obj;
    }

    public static T IncreaseButton<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.IncreaseButtonProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IncreaseButton(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.IncreaseButtonProperty.Bind().WithMode(mode)];
    }

    // DecreaseButtonProperty

    public static T DecreaseButton<T>(this T obj, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.DecreaseButtonProperty] = value;
        return obj;
    }

    public static T DecreaseButton<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.DecreaseButtonProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding DecreaseButton(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.DecreaseButtonProperty.Bind().WithMode(mode)];
    }

    // IsDirectionReversedProperty

    public static T IsDirectionReversed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty] = value;
        return obj;
    }

    public static T IsDirectionReversed<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsDirectionReversed(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty.Bind().WithMode(mode)];
    }

    // IgnoreThumbDragProperty

    public static T IgnoreThumbDrag<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty] = value;
        return obj;
    }

    public static T IgnoreThumbDrag<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Track
    {
        obj[Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IgnoreThumbDrag(this Avalonia.Controls.Primitives.Track obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty.Bind().WithMode(mode)];
    }
}
