using Microsoft.Azure.Cosmos;

namespace Lekcja0102.Services
{
    public class InitCosmo
    {
        public static async Task<CosmoService> InitalizeCosmoClientInstanceAync(IConfigurationSection configurationSection)
        {
            string databaseName = configurationSection.GetSection("DatabaseName").Value;
            string containerName = configurationSection.GetSection("ContainerName").Value;
            string account = configurationSection.GetSection("Account").Value;
            string key = configurationSection.GetSection("Key").Value;   

            CosmosClient dbClient = new CosmosClient(account, key);

            CosmoService cosmoService = new CosmoService(dbClient, databaseName, containerName);

            DatabaseResponse databaseResponse = await dbClient.CreateDatabaseIfNotExistsAsync(databaseName);

            await databaseResponse.Database.CreateContainerIfNotExistsAsync(containerName, "/id");

            return cosmoService;
        }
    }
}
