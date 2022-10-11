namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.DurationProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.TimeSpan> AnimationDuration => Avalonia.Animation.Animation.DurationProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.IterationCountProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.IterationCount> AnimationIterationCount => Avalonia.Animation.Animation.IterationCountProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.PlaybackDirectionProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.PlaybackDirection> AnimationPlaybackDirection => Avalonia.Animation.Animation.PlaybackDirectionProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.FillModeProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.FillMode> AnimationFillMode => Avalonia.Animation.Animation.FillModeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.EasingProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.Easings.Easing> AnimationEasing => Avalonia.Animation.Animation.EasingProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.DelayProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.TimeSpan> AnimationDelay => Avalonia.Animation.Animation.DelayProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.DelayBetweenIterationsProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.TimeSpan> AnimationDelayBetweenIterations => Avalonia.Animation.Animation.DelayBetweenIterationsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animation.SpeedRatioProperty"/> property defined in <see cref="Avalonia.Animation.Animation"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.Double> AnimationSpeedRatio => Avalonia.Animation.Animation.SpeedRatioProperty;
}
