using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace NewTab.Web.Models;

public class BookmarksContainer
{
	[Json("roots")] 
	public Roots? Roots { get; set; }
}