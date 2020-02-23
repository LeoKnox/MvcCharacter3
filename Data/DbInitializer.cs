using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCharacter.Data;
using MvcCharacter.Models;

namespace MvcCharacter.Data
{
    public class DbInitializer
    {
        public static void Initialize(MvcCharacterContext context)
        {
            context.Database.EnsureCreated();

            if (context.Character.Any())
            {
                return;
            }

            var characters = new Character[]
            {
                new Character{Name="Xingu",Atk=15,Def=12,Life=26 },
                new Character{Name="Aelien",Atk=14,Def=14,Life=22 },
                new Character{Name="Eveehi",Atk=17,Def=9,Life=18}
            };
            foreach (Character c in characters)
            {
                context.Character.Add(c);
            }
            context.SaveChanges();

            var levels = new Level[]
            {
                new Level{LevelID=1, CharacterID=1, Skills=}
            }

            var abilities = new Ability[]
            {
                new Ability{LevelID=1, CharacterID=1, CharacterClass = CharacterClass.Thief},
                new Ability{LevelID=3, CharacterID=2, CharacterClass = CharacterClass.Wizard },
                new Ability{LevelID=4, CharacterID=3, CharacterClass = CharacterClass.Warrior},
            };
            foreach (Ability a in abilities)
            {
                context.Abilities.Add(a);
            }
            context.SaveChanges();
        }
    }
}
