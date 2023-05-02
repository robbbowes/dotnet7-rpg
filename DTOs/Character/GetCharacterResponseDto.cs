using dotnet7_rpg.DTOs.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_rpg.DTOs.Character
{
    public class GetCharacterResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RPGClass Class { get; set; } = RPGClass.Knight;
        public GetWeaponResponseDto? Weapon { get; set; }
        public List<GetSkillRequestDto>? Skills { get; set; }
    }
}