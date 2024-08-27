using System.Text.Json;
using Coffeman.Models;

public class MenuService
{
    private readonly HttpClient _httpClient;

    public MenuService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Category[]> GetCategoriesAsync()
    {
        var json = await _httpClient.GetStringAsync("data/menu-data.json");
        var menuData = JsonSerializer.Deserialize<MenuData>(json);
        return menuData.Categories;
    }
}
