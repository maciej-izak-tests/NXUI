namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/> property defined in <see cref="Avalonia.Controls.DataValidationErrors"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<System.Collections.Generic.IEnumerable<System.Object>> DataValidationErrorsErrors => Avalonia.Controls.DataValidationErrors.ErrorsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/> property defined in <see cref="Avalonia.Controls.DataValidationErrors"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<System.Boolean> DataValidationErrorsHasErrors => Avalonia.Controls.DataValidationErrors.HasErrorsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/> property defined in <see cref="Avalonia.Controls.DataValidationErrors"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> DataValidationErrorsErrorTemplate => Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/> property defined in <see cref="Avalonia.Controls.DataValidationErrors"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.DataValidationErrors,Avalonia.Controls.Control> DataValidationErrorsOwner => Avalonia.Controls.DataValidationErrors.OwnerProperty;
}
