namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Animation.Animatable.ClockProperty"/> property defined in <see cref="Avalonia.Animation.Animatable"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Animation.IClock> AnimatableClock => Avalonia.Animation.Animatable.ClockProperty;

    /// <summary>
    /// The <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/> property defined in <see cref="Avalonia.Animation.Animatable"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Animation.Transitions> AnimatableTransitions => Avalonia.Animation.Animatable.TransitionsProperty;
}
