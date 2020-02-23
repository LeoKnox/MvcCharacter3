
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Life { get; set; }

        public ICollection<Ability> Abilities { get; set; }
    }
}