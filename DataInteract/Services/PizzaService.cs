using DataInteractShared;

namespace DataInteract.Services
{
    public class PizzaService
    {

        public async Task<PizzaSpecial[]> DajPizzeAsync()
        {
            return [new PizzaSpecial()];
        }
    }
}
