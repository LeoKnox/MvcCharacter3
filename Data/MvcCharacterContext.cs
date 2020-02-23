using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Models;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Models;

namespace MvcCharacter.Data
{
    public class MvcCharacterContext : DbContext
    {
        public MvcCharacterContext (DbContextOptions<MvcCharacterContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Character { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Ability> Abilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>().ToTable("Ability");
            modelBuilder.Entity<Level>().ToTable("Level");
            modelBuilder.Entity<Character>().ToTable("Character");
        }
    }
}
