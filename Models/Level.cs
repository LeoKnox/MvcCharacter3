using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCharacter.Models
{
    public class Level
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelID { get; set; }
        public string CharacterClass { get; set; }
        public int Skills { get; set; }

        public ICollection<Ability> Abilities { get; set; }
    }
}