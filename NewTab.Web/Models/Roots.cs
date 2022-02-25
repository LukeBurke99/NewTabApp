using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace NewTab.Web.Models;

public class Roots
{
	[Json("other")] 
	public Bookmark? Other { get; set; }
}