using System.Threading.Tasks;
using DMScreen.Core.Interfaces.Repositories;
using DMScreen.Core.Interfaces.Services;
using DMScreen.Core.Models;

namespace DMScreen.Core.Services
{
    public class PlayerCharacterService : IPlayerCharacterService
    {
        private readonly IPlayerCharacterRepository _playerCharacterRepository;

        public PlayerCharacterService(IPlayerCharacterRepository playerCharacterRepository)
        {
            _playerCharacterRepository = playerCharacterRepository;
        }

        public async Task<PlayerCharacterDomain> GetPlayerCharacterByIdAsync(int pcId)
        {
            return await _playerCharacterRepository.GetPlayerCharacterByIdAsync(pcId);
        }
    }
}