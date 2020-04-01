using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using DMScreen.Api.DTOs;
using DMScreen.Core.Interfaces.Services;
using DMScreen.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMScreen.Api.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharactersController
    {
        private readonly IPlayerCharacterService _playerCharacterService;
        private readonly IMapper _mapper;

        public PlayerCharactersController(IPlayerCharacterService playerCharacterService, IMapper mapper)
        {
            _playerCharacterService = playerCharacterService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PlayerCharacter>> Get(int id)
        {
            var pcResult = await _playerCharacterService.GetPlayerCharacterByIdAsync(id);
            return _mapper.Map<PlayerCharacter>(pcResult);
        }
    }
}