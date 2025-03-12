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
                Types t1 = new Types() { TypeID = 1, PokeType = "Fire" , Effective = "Grass" , Weakness = "Water"};
                Types t2 = new Types() { TypeID = 2, PokeType = "Water", Effective = "Fire", Weakness = "Electric" };
                Types t3 = new Types() { TypeID = 3, PokeType = "Grass", Effective = "Fighing", Weakness = "Fire" };
                Types t4 = new Types() { TypeID = 4, PokeType = "Psycic", Effective = "Fighting", Weakness = "Dark" };  //not effective against anything give extra hp / stronger moves
                Types t5 = new Types() { TypeID = 5, PokeType = "Electric", Effective = "Water", Weakness = "Fighting" };
                Types t6 = new Types() { TypeID = 6, PokeType = "Dark", Effective = "Psycic", Weakness = "Normal" };  
                Types t7 = new Types() { TypeID = 7, PokeType = "Normal", Effective = "Normal", Weakness = "Fighting" };
                Types t8 = new Types() { TypeID = 8, PokeType = "Fighting", Effective = "Electric", Weakness = "Grass" };   // strong against loads of types but alos weak against loads

                


               

                Pokemon p1 = new Pokemon() { PokeDexID = 1, PokemonName = "Charizard", Types = t1 };









            }

        }
    }
}
