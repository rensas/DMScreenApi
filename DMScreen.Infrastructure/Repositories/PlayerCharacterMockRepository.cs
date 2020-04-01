using System.Threading.Tasks;
using DMScreen.Core.Interfaces.Repositories;
using DMScreen.Core.Models;

namespace DMScreen.Infrastructure.Repositories
{
    public class PlayerCharacterMockRepository : IPlayerCharacterRepository
    {
        public async Task<PlayerCharacterDomain> GetPlayerCharacterByIdAsync(int pcId)
        {
            return new PlayerCharacterDomain() {CharacterName = "Elroy Mezzovit"}; 
        }
    }
}