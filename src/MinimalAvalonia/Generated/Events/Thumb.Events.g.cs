namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.Thumb.DragStartedEvent"/> event defined in <see cref="Avalonia.Controls.Primitives.Thumb"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.VectorEventArgs> ThumbDragStarted => Avalonia.Controls.Primitives.Thumb.DragStartedEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.Thumb.DragDeltaEvent"/> event defined in <see cref="Avalonia.Controls.Primitives.Thumb"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.VectorEventArgs> ThumbDragDelta => Avalonia.Controls.Primitives.Thumb.DragDeltaEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.Thumb.DragCompletedEvent"/> event defined in <see cref="Avalonia.Controls.Primitives.Thumb"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.VectorEventArgs> ThumbDragCompleted => Avalonia.Controls.Primitives.Thumb.DragCompletedEvent;
}
