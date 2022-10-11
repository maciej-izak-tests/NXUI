namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> property defined in <see cref="Avalonia.Themes.Fluent.FluentTheme"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Themes.Fluent.FluentThemeMode> FluentThemeMode => Avalonia.Themes.Fluent.FluentTheme.ModeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> property defined in <see cref="Avalonia.Themes.Fluent.FluentTheme"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Themes.Fluent.DensityStyle> FluentThemeDensityStyle => Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty;
}
