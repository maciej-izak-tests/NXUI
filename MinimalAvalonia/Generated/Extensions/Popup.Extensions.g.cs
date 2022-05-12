// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class PopupExtensions
{
    // WindowManagerAddShadowHintProperty

    public static T WindowManagerAddShadowHint<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty] = value;
        return obj;
    }

    public static T WindowManagerAddShadowHint<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty.Bind().WithMode(mode)];
    }

    // ChildProperty

    public static T Child<T>(this T obj, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.ChildProperty] = value;
        return obj;
    }

    public static T Child<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.ChildProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Child(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.ChildProperty.Bind().WithMode(mode)];
    }

    // InheritsTransformProperty

    public static T InheritsTransform<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.InheritsTransformProperty] = value;
        return obj;
    }

    public static T InheritsTransform<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.InheritsTransformProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding InheritsTransform(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.InheritsTransformProperty.Bind().WithMode(mode)];
    }

    // IsOpenProperty

    public static T IsOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.IsOpenProperty] = value;
        return obj;
    }

    public static T IsOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.IsOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsOpen(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.IsOpenProperty.Bind().WithMode(mode)];
    }

    // PlacementAnchorProperty

    public static T PlacementAnchor<T>(this T obj, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = value;
        return obj;
    }

    public static T PlacementAnchor<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PlacementAnchor(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty.Bind().WithMode(mode)];
    }

    public static T PlacementAnchorNone<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.None;
        return obj;
    }

    public static T PlacementAnchorTop<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.Top;
        return obj;
    }

    public static T PlacementAnchorBottom<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.Bottom;
        return obj;
    }

    public static T PlacementAnchorVerticalMask<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.VerticalMask;
        return obj;
    }

    public static T PlacementAnchorLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.Left;
        return obj;
    }

    public static T PlacementAnchorTopLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.TopLeft;
        return obj;
    }

    public static T PlacementAnchorBottomLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.BottomLeft;
        return obj;
    }

    public static T PlacementAnchorRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.Right;
        return obj;
    }

    public static T PlacementAnchorTopRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.TopRight;
        return obj;
    }

    public static T PlacementAnchorBottomRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.BottomRight;
        return obj;
    }

    public static T PlacementAnchorHorizontalMask<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.HorizontalMask;
        return obj;
    }

    public static T PlacementAnchorAllMask<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor.AllMask;
        return obj;
    }

    // PlacementConstraintAdjustmentProperty

    public static T PlacementConstraintAdjustment<T>(this T obj, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = value;
        return obj;
    }

    public static T PlacementConstraintAdjustment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PlacementConstraintAdjustment(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty.Bind().WithMode(mode)];
    }

    public static T PlacementConstraintAdjustmentNone<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.None;
        return obj;
    }

    public static T PlacementConstraintAdjustmentSlideX<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.SlideX;
        return obj;
    }

    public static T PlacementConstraintAdjustmentSlideY<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.SlideY;
        return obj;
    }

    public static T PlacementConstraintAdjustmentFlipX<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.FlipX;
        return obj;
    }

    public static T PlacementConstraintAdjustmentFlipY<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.FlipY;
        return obj;
    }

    public static T PlacementConstraintAdjustmentResizeX<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.ResizeX;
        return obj;
    }

    public static T PlacementConstraintAdjustmentResizeY<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.ResizeY;
        return obj;
    }

    public static T PlacementConstraintAdjustmentAll<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment.All;
        return obj;
    }

    // PlacementGravityProperty

    public static T PlacementGravity<T>(this T obj, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = value;
        return obj;
    }

    public static T PlacementGravity<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PlacementGravity(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty.Bind().WithMode(mode)];
    }

    public static T PlacementGravityNone<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.None;
        return obj;
    }

    public static T PlacementGravityTop<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.Top;
        return obj;
    }

    public static T PlacementGravityBottom<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.Bottom;
        return obj;
    }

    public static T PlacementGravityLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.Left;
        return obj;
    }

    public static T PlacementGravityTopLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.TopLeft;
        return obj;
    }

    public static T PlacementGravityBottomLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.BottomLeft;
        return obj;
    }

    public static T PlacementGravityRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.Right;
        return obj;
    }

    public static T PlacementGravityTopRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.TopRight;
        return obj;
    }

    public static T PlacementGravityBottomRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementGravityProperty] = Avalonia.Controls.Primitives.PopupPositioning.PopupGravity.BottomRight;
        return obj;
    }

    // PlacementModeProperty

    public static T PlacementMode<T>(this T obj, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = value;
        return obj;
    }

    public static T PlacementMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PlacementMode(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty.Bind().WithMode(mode)];
    }

    public static T PlacementModePointer<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = Avalonia.Controls.PlacementMode.Pointer;
        return obj;
    }

    public static T PlacementModeBottom<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = Avalonia.Controls.PlacementMode.Bottom;
        return obj;
    }

    public static T PlacementModeRight<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = Avalonia.Controls.PlacementMode.Right;
        return obj;
    }

    public static T PlacementModeLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = Avalonia.Controls.PlacementMode.Left;
        return obj;
    }

    public static T PlacementModeTop<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = Avalonia.Controls.PlacementMode.Top;
        return obj;
    }

    public static T PlacementModeAnchorAndGravity<T>(this T obj) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementModeProperty] = Avalonia.Controls.PlacementMode.AnchorAndGravity;
        return obj;
    }

    // PlacementRectProperty

    public static T PlacementRect<T>(this T obj, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementRectProperty] = value;
        return obj;
    }

    public static T PlacementRect<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementRectProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PlacementRect(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.PlacementRectProperty.Bind().WithMode(mode)];
    }

    // PlacementTargetProperty

    public static T PlacementTarget<T>(this T obj, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementTargetProperty] = value;
        return obj;
    }

    public static T PlacementTarget<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.PlacementTargetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PlacementTarget(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.PlacementTargetProperty.Bind().WithMode(mode)];
    }

    // ObeyScreenEdgesProperty

    public static T ObeyScreenEdges<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.ObeyScreenEdgesProperty] = value;
        return obj;
    }

    public static T ObeyScreenEdges<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.ObeyScreenEdgesProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ObeyScreenEdges(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.ObeyScreenEdgesProperty.Bind().WithMode(mode)];
    }

    // OverlayDismissEventPassThroughProperty

    public static T OverlayDismissEventPassThrough<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty] = value;
        return obj;
    }

    public static T OverlayDismissEventPassThrough<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OverlayDismissEventPassThrough(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty.Bind().WithMode(mode)];
    }

    // OverlayInputPassThroughElementProperty

    public static T OverlayInputPassThroughElement<T>(this T obj, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty] = value;
        return obj;
    }

    public static T OverlayInputPassThroughElement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OverlayInputPassThroughElement(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty.Bind().WithMode(mode)];
    }

    // HorizontalOffsetProperty

    public static T HorizontalOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty] = value;
        return obj;
    }

    public static T HorizontalOffset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding HorizontalOffset(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty.Bind().WithMode(mode)];
    }

    // IsLightDismissEnabledProperty

    public static T IsLightDismissEnabled<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty] = value;
        return obj;
    }

    public static T IsLightDismissEnabled<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsLightDismissEnabled(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty.Bind().WithMode(mode)];
    }

    // VerticalOffsetProperty

    public static T VerticalOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty] = value;
        return obj;
    }

    public static T VerticalOffset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding VerticalOffset(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty.Bind().WithMode(mode)];
    }

    // TopmostProperty

    public static T Topmost<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.TopmostProperty] = value;
        return obj;
    }

    public static T Topmost<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.Popup
    {
        obj[Avalonia.Controls.Primitives.Popup.TopmostProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Topmost(this Avalonia.Controls.Primitives.Popup obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.Popup.TopmostProperty.Bind().WithMode(mode)];
    }
}
