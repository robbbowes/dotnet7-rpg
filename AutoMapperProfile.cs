using dotnet7_rpg.DTOs.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>();
            CreateMap<AddCharacterRequestDto, Character>();
            CreateMap<UpdateCharacterRequestDto, Character>();

            CreateMap<AddWeaponRequestDto, Weapon>();
            CreateMap<Weapon, GetWeaponResponseDto>();

            CreateMap<Skill, GetSkillRequestDto>();
        }
    }
}