using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace NewTab.Web.Models;

public class Bookmark
{
    [Json("children")]
    public List<Bookmark>? Children { get; set; }

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


    public Bookmark() { }
    public Bookmark(Bookmark? bookmark)
    {
        if (bookmark == null) return;

        if (bookmark.Children != null) {
            Children = new();
            Children.AddRange(bookmark.Children);
        }

        DateAdded = bookmark.DateAdded;
        DateModified = bookmark.DateModified;
        Guid = bookmark.Guid;
        Id = bookmark.Id;
        Name = bookmark.Name;
        Type = bookmark.Type;
        Url = bookmark.Url;
    }
}