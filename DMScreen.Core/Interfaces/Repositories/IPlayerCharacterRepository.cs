using System.Threading.Tasks;
using DMScreen.Core.Models;

namespace DMScreen.Core.Interfaces.Repositories
{
    public interface IPlayerCharacterRepository
    {
        public Task<PlayerCharacterDomain> GetPlayerCharacterByIdAsync(int pcId);
    }
}