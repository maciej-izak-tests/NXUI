namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Slider.OrientationProperty"/> property defined in <see cref="Avalonia.Controls.Slider"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> SliderOrientation => Avalonia.Controls.Slider.OrientationProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/> property defined in <see cref="Avalonia.Controls.Slider"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> SliderIsDirectionReversed => Avalonia.Controls.Slider.IsDirectionReversedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/> property defined in <see cref="Avalonia.Controls.Slider"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> SliderIsSnapToTickEnabled => Avalonia.Controls.Slider.IsSnapToTickEnabledProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/> property defined in <see cref="Avalonia.Controls.Slider"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> SliderTickFrequency => Avalonia.Controls.Slider.TickFrequencyProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> property defined in <see cref="Avalonia.Controls.Slider"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.TickPlacement> SliderTickPlacement => Avalonia.Controls.Slider.TickPlacementProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Slider.TicksProperty"/> property defined in <see cref="Avalonia.Controls.Slider"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Collections.AvaloniaList<System.Double>> SliderTicks => Avalonia.Controls.Slider.TicksProperty;
}
