namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/> property defined in <see cref="Avalonia.Controls.Carousel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> CarouselIsVirtualized => Avalonia.Controls.Carousel.IsVirtualizedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/> property defined in <see cref="Avalonia.Controls.Carousel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> CarouselPageTransition => Avalonia.Controls.Carousel.PageTransitionProperty;
}
