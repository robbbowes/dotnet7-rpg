using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet7_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> Get(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> Add(AddCharacterRequestDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> Update(UpdateCharacterRequestDto updatedCharacter)
        {
            var serviceResponse = await _characterService.UpdateCharacter(updatedCharacter);
            if (serviceResponse.Data is null)
            {
                return NotFound(serviceResponse);
            }
            return Ok(serviceResponse);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> Delete(int id)
        {
            var serviceResponse = await _characterService.DeleteCharacter(id);
            if (serviceResponse.Data is null)
            {
                return NotFound(serviceResponse);
            }
            return Ok(serviceResponse);
        }

    }
}