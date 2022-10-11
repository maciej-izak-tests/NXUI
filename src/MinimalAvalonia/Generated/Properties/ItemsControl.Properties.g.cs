namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/> property defined in <see cref="Avalonia.Controls.ItemsControl"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.ItemsControl,System.Collections.IEnumerable> ItemsControlItems => Avalonia.Controls.ItemsControl.ItemsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> property defined in <see cref="Avalonia.Controls.ItemsControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Styling.ControlTheme> ItemsControlItemContainerTheme => Avalonia.Controls.ItemsControl.ItemContainerThemeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/> property defined in <see cref="Avalonia.Controls.ItemsControl"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.ItemsControl,System.Int32> ItemsControlItemCount => Avalonia.Controls.ItemsControl.ItemCountProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> property defined in <see cref="Avalonia.Controls.ItemsControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> ItemsControlItemsPanel => Avalonia.Controls.ItemsControl.ItemsPanelProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> property defined in <see cref="Avalonia.Controls.ItemsControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> ItemsControlItemTemplate => Avalonia.Controls.ItemsControl.ItemTemplateProperty;
}
