using Microsoft.AspNetCore.Components;

namespace NeoUI.Blazor;

/// <summary>
/// The header section of a card component.
/// </summary>
/// <remarks>
/// <para>
/// CardHeader provides a distinct top section for card content, typically containing
/// a title, description, and optional action elements. It uses flexbox for layout
/// with proper spacing between child elements.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// &lt;CardHeader&gt;
///     &lt;CardTitle&gt;Card Title&lt;/CardTitle&gt;
///     &lt;CardDescription&gt;Card description&lt;/CardDescription&gt;
/// &lt;/CardHeader&gt;
/// </code>
/// </example>
public partial class CardHeader : ComponentBase
{
    /// <summary>
    /// Gets or sets the content to be rendered inside the card header.
    /// </summary>
    /// <remarks>
    /// Typically contains CardTitle, CardDescription, and optionally CardAction.
    /// </remarks>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or sets additional CSS classes to apply to the card header.
    /// </summary>
    [Parameter]
    public string? Class { get; set; }

    /// <summary>
    /// Gets the computed CSS classes for the card header element.
    /// </summary>
    private string CssClass => ClassNames.cn(
        // Base header styles (from shadcn/ui)
        "grid auto-rows-min items-start gap-1.5 px-6 has-data-[slot=card-action]:grid-cols-[1fr_auto] has-data-[slot=card-description]:grid-rows-[auto_auto] [.border-b]:pb-6",
        // Custom classes (if provided)
        Class
    );
}
