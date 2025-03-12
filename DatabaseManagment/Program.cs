using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattle;

namespace DatabaseManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokeData db = new PokeData();

            using (db)
            {       //declare all types, attack, defence and specials before initalising the pokemon 
                    // because we need everything initalised before we state the pokemon 
                Types t1 = new Types() { TypeID = 1 ,PokeType = "Fire" , Effective = "Grass" , Weakness = "Water"};
                Types t2 = new Types() { TypeID = 2, PokeType = "Water", Effective = "Fire", Weakness = "Grass" };
                Types t3 = new Types() { TypeID = 3, PokeType = "Grass", Effective = "Water", Weakness = "Fire" };
                Types t4 = new Types() { TypeID = 4, PokeType = "Rock", Effective = "Fighting", Weakness = "Grass" };
                Types t5 = new Types() { TypeID = 5, PokeType = "Ground", Effective = "Fire", Weakness = "Water" };
                Types t6 = new Types() { TypeID = 6, PokeType = "Psycic", Effective = "Dark", Weakness = "Fairy" };
                Types t7 = new Types() { TypeID = 7, PokeType = "Fairy", Effective = "Psycic", Weakness = "Flying" };
                Types t8 = new Types() { TypeID = 8, PokeType = "Flying", Effective = "Grass", Weakness = "Rock" };
                Types t9 = new Types() { TypeID = 9, PokeType = "Electric", Effective = "Flying", Weakness = "Ground" };
                Types t10 = new Types() { TypeID = 10, PokeType = "Dark", Effective = "Fairy", Weakness = "Psycic" };

                Attacks




                Pokemon p1 = new Pokemon() { PokeDexID = 1, PokemonName = "Charizard", PokeType = "Fire", Types = t1 };









            }

        }
    }
}
