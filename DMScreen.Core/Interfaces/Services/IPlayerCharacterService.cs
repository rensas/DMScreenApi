using System.Threading.Tasks;
using DMScreen.Core.Models;

namespace DMScreen.Core.Interfaces.Services
{
    public interface IPlayerCharacterService
    {
        public Task<PlayerCharacterDomain> GetPlayerCharacterByIdAsync(int pcId);
    }
}