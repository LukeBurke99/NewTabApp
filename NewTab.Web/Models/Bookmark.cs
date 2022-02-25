using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace NewTab.Web.Models;

public class Bookmark
{
	[Json("children")]
	public Bookmark[]? Children { get; set; }

	[Json("date_added")]
	public string? DateAdded { get; set; }

	[Json("date_modified")]
	public string? DateModified { get; set; }

	[Json("guid")]
	public Guid? Guid { get; set; }

	[Json("id")]
	public string? Id { get; set; }

	[Json("name")]
	public string? Name { get; set; }

	[Json("type")]
	public string? Type { get; set; }

	[Json("url")]
	public string? Url { get; set; }
}