using NewTab.Web.Models;
using Newtonsoft.Json;

namespace NewTab.Web.Services;

public class BookmarkService
{
	public async Task<Bookmark?> GetBookmarksAsync(string bookmarkFileLocation)
	{
		if (!File.Exists(bookmarkFileLocation))
			throw new FileNotFoundException("The Bookmarks file does not exist at that location.");

		var json = await File.ReadAllTextAsync(bookmarkFileLocation);
		if (string.IsNullOrEmpty(json))
			return null;

		try {
			var bookmarks = JsonConvert.DeserializeObject<BookmarksContainer>(json);
			var newTabBookmarks = bookmarks?.Roots?.Other?.Children?.FirstOrDefault(x => x.Name == "NewTab");

			return newTabBookmarks ?? null;
		} catch(Exception e) {
			Console.WriteLine(e.Message);
			return null;
		}
	}
}