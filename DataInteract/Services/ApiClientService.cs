using DataInteractShared;

namespace DataInteract.Services
{
    public class ApiClientService(HttpClient httpClient)
    {
        private readonly string _specialsUrl = "https://localhost:7064/specials";
        public async Task<List<PizzaSpecial>> DajPizzaSpecials()
        {
            return await httpClient.GetFromJsonAsync<List<PizzaSpecial>>(_specialsUrl) ?? [];
        }


    }
}
