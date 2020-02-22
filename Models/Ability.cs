using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public enum CharacterClass
    {
        Warrior, Wizard, Thief
    }
    public class Ability
    {
        public int AbilityID { get; set; }
        public int LevelID { get; set; }
        public int CharacterID { get; set; }
        public CharacterClass? CharacterClass { get; set; }

        public Level Level { get; set; }
        public Character Character { get; set; }
    }
}
