using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class Pokemon
    {
        public int PokeDexID { get; set; }
        public string PokemonName { get; set; }
        public string PokeType { get; set; }


        public virtual Types Types { get; set; }

    }
    public class Types
    {
        public int TypeID {  get; set; }    
        public string PokeType { get; set; }
        public string Weakness { get; set; }
        public string Effective { get; set; }

        public virtual List<Pokemon> Poke { get; set; }
    }
    public class Attacks
    {
        public int MoveID { set; get; }
        public string PokeType { get; set; }
        public string Attack { get; set; }
        public int Accuracy {  set; get; }

    }
    public class Defence
    {
        public int MoveID { set; get; }
        public string PokeType { get; set; }
        public string Defend { get; set; }
        public int Accuracy { set; get; }
    }
    public class Special
    {
        public int MoveID { set; get; }
        public string PokeType { get; set; }
        public string SpecialMove { get; set; }
        public int Accuracy { get; set; }
    }
 

    public class PokeData : DbContext
    {
        public PokeData() : base("PokeDex") { }

        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Attacks> Attacks { get; set; }
        public DbSet<Defence> Defence { get; set; }
        public DbSet<Special> Special { get; set; }
    }
}



