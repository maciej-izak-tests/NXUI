namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.StyledElement.DataContextProperty"/> property defined in <see cref="Avalonia.StyledElement"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> StyledElementDataContext => Avalonia.StyledElement.DataContextProperty;

    /// <summary>
    /// The <see cref="Avalonia.StyledElement.NameProperty"/> property defined in <see cref="Avalonia.StyledElement"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.StyledElement,System.String> StyledElementName => Avalonia.StyledElement.NameProperty;

    /// <summary>
    /// The <see cref="Avalonia.StyledElement.ParentProperty"/> property defined in <see cref="Avalonia.StyledElement"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.StyledElement,Avalonia.IStyledElement> StyledElementParent => Avalonia.StyledElement.ParentProperty;

    /// <summary>
    /// The <see cref="Avalonia.StyledElement.TemplatedParentProperty"/> property defined in <see cref="Avalonia.StyledElement"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.StyledElement,Avalonia.Styling.ITemplatedControl> StyledElementTemplatedParent => Avalonia.StyledElement.TemplatedParentProperty;

    /// <summary>
    /// The <see cref="Avalonia.StyledElement.ThemeProperty"/> property defined in <see cref="Avalonia.StyledElement"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Styling.ControlTheme> StyledElementTheme => Avalonia.StyledElement.ThemeProperty;
}
