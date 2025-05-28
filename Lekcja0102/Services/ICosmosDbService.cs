using Lekcja0102.Models;

namespace Lekcja0102.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Element>> GetItemsAsync(string query);
        Task<Element> GetItemAsync(string id);
        Task AddItemAsync(Element item);
        Task UpdateItemAsync(string id, Element item);
        Task DeleteItemAsync(string id);
    }
}