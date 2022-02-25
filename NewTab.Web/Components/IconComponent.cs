using Microsoft.AspNetCore.Components;

namespace NewTab.Web.Components;

public class IconComponent : ComponentBase
{
	[Parameter] public int Width { get; set; } = 16;

	[Parameter] public int Height { get; set; } = 16;

	[Parameter] public string Color { get; set; } = "currentColor";
}