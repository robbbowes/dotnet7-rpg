using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_rpg.DTOs.User
{
    public class UserRegisterRequestDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}