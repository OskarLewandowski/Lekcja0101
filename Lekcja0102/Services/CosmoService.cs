using Lekcja0102.Models;
using Microsoft.Azure.Cosmos;
using System.ComponentModel;

namespace Lekcja0102.Services
{
    public class CosmoService : ICosmosDbService
    {
        private Microsoft.Azure.Cosmos.Container _container;

        public CosmoService(CosmosClient dbClient, string databasename, string containerName)
        {
            this._container = dbClient.GetContainer(databasename, containerName);
        }

        public async Task AddItemAsync(Element item)
        {
            await this._container.CreateItemAsync<Element>(item, new PartitionKey(item.Id));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<Element>(id, new PartitionKey(id));
        }

        public async Task<Element> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<Element> response =
                    await this._container.ReadItemAsync<Element>(id, new PartitionKey(id));

                return response.Resource;
            }
            catch (CosmosException ex)
            when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null; // Item not found
            }
        }

        public async Task<IEnumerable<Element>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Element>
                (new QueryDefinition(queryString));

            List<Element> results = new List<Element>();

            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task UpdateItemAsync(string id, Element item)
        {
            this._container.UpsertItemAsync<Element>(item, new PartitionKey(id));
        }
    }
}
