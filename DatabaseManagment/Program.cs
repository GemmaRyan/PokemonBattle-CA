using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattle;
using static System.Net.WebRequestMethods;

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
                //Types t1 = new Types() { TypeID = 1, PokeType = "Fire" , Effective = "Grass" , Weakness = "Water"};
                //Types t2 = new Types() { TypeID = 2, PokeType = "Water", Effective = "Fire", Weakness = "Electric" };       //temporarily change to test
                //Types t3 = new Types() { TypeID = 3, PokeType = "Grass", Effective = "Fighing", Weakness = "Fire" };


                Types t1 = new Types() { TypeID = 1, PokeType = "Fire", Effective = "Grass", Weakness = "Water" };
                Types t2 = new Types() { TypeID = 2, PokeType = "Water", Effective = "Fire", Weakness = "Grass" };       //delete after
                Types t3 = new Types() { TypeID = 3, PokeType = "Grass", Effective = "Water", Weakness = "Fire" };



                //Types t4 = new Types() { TypeID = 4, PokeType = "Psycic", Effective = "Fighting", Weakness = "Dark" };  //not effective against anything give extra hp / stronger moves
                //Types t5 = new Types() { TypeID = 5, PokeType = "Electric", Effective = "Water", Weakness = "Fighting" };
                //Types t6 = new Types() { TypeID = 6, PokeType = "Dark", Effective = "Psycic", Weakness = "Normal" };  
                //Types t7 = new Types() { TypeID = 7, PokeType = "Normal", Effective = "Normal", Weakness = "Fighting" };
                //Types t8 = new Types() { TypeID = 8, PokeType = "Fighting", Effective = "Electric", Weakness = "Grass" };   // strong against loads of types but alos weak against loads






                Pokemon p1 = new Pokemon() { PokeDexID = 1, PokemonName = "Charizard", Types = t1, ImageURL_Back = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/6.png", ImageURL_Front = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png", Health = 280 };
                Pokemon p2 = new Pokemon() { PokeDexID = 2, PokemonName = "Venusaur", Types = t3, ImageURL_Back = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/3.png", ImageURL_Front = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png", Health = 350 };
                Pokemon p3 = new Pokemon() {PokeDexID = 3, PokemonName = "Blastoise", Types = t2, ImageURL_Back = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/9.png", ImageURL_Front = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png" , Health=300};
                
                //Pokemon p4 = new Pokemon() { PokeDexID = 1, PokemonName = "Charizard", Types = t1 };









            }

        }
    }
}
