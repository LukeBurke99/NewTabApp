using NewTab.Web.Models;
using Newtonsoft.Json;

namespace NewTab.Web.Services;

public class BookmarkService
{
	public async Task<Bookmark?> GetBookmarksAsync()
	{
		const string path = @"C:\Users\lukej\AppData\Local\Google\Chrome\User Data\Default\Bookmarks";

		if (!File.Exists(path))
			throw new FileNotFoundException("The Bookmarks file does not exist at that location.");

		var json = await File.ReadAllTextAsync(path);
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