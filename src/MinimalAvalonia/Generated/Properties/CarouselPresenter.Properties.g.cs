namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Presenters.CarouselPresenter.IsVirtualizedProperty"/> property defined in <see cref="Avalonia.Controls.Presenters.CarouselPresenter"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> CarouselPresenterIsVirtualized => Avalonia.Controls.Presenters.CarouselPresenter.IsVirtualizedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Presenters.CarouselPresenter.SelectedIndexProperty"/> property defined in <see cref="Avalonia.Controls.Presenters.CarouselPresenter"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.CarouselPresenter,System.Int32> CarouselPresenterSelectedIndex => Avalonia.Controls.Presenters.CarouselPresenter.SelectedIndexProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Presenters.CarouselPresenter.PageTransitionProperty"/> property defined in <see cref="Avalonia.Controls.Presenters.CarouselPresenter"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> CarouselPresenterPageTransition => Avalonia.Controls.Presenters.CarouselPresenter.PageTransitionProperty;
}
