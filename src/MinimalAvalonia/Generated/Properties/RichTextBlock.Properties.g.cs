namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty"/> property defined in <see cref="Avalonia.Controls.RichTextBlock"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> RichTextBlockIsTextSelectionEnabled => Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.RichTextBlock.SelectionStartProperty"/> property defined in <see cref="Avalonia.Controls.RichTextBlock"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.RichTextBlock,System.Int32> RichTextBlockSelectionStart => Avalonia.Controls.RichTextBlock.SelectionStartProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.RichTextBlock.SelectionEndProperty"/> property defined in <see cref="Avalonia.Controls.RichTextBlock"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.RichTextBlock,System.Int32> RichTextBlockSelectionEnd => Avalonia.Controls.RichTextBlock.SelectionEndProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.RichTextBlock.SelectedTextProperty"/> property defined in <see cref="Avalonia.Controls.RichTextBlock"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.RichTextBlock,System.String> RichTextBlockSelectedText => Avalonia.Controls.RichTextBlock.SelectedTextProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.RichTextBlock.SelectionBrushProperty"/> property defined in <see cref="Avalonia.Controls.RichTextBlock"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> RichTextBlockSelectionBrush => Avalonia.Controls.RichTextBlock.SelectionBrushProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.RichTextBlock.InlinesProperty"/> property defined in <see cref="Avalonia.Controls.RichTextBlock"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Documents.InlineCollection> RichTextBlockInlines => Avalonia.Controls.RichTextBlock.InlinesProperty;
}
