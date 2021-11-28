using System.Collections.Generic;
using dotnet_rpg.Models;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id=1, Name = "Sam"}
        }; 
        public async Task<List<Character>> AddCharacter(Character c)
        {
            characters.Add(c);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(character=>character.Id==id);
        }
    }
}