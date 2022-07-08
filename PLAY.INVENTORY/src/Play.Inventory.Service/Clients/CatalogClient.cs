using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Play.Inventory.Service.Clients
{
    public class CatalogClient
    {
        private HttpClient HttpClient{ get; }

        public CatalogClient(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<CatalogItemDto>> GetCatalogItemsAsync()
        {
            var catalogItems = await HttpClient.GetFromJsonAsync<IReadOnlyCollection<CatalogItemDto>>("api/items");
            return catalogItems;    
        }
    }
}
