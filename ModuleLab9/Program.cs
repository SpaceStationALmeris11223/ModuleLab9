using System;//key word that pulls in nother class at the compile time
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;


class PokemonLinqLab {
    static void Main() {

     //Use void becuas it doesn't return anything
    //Sample data: List of Pokemon
    var pokemon = new List<Pokemon>
    {
        new Pokemon {ID = 1, Name = "Bulbasaur", Type = "Grass", Level =  16 },
        new Pokemon {ID = 4, Name = "Charmander", Type = "Fire", Level =  15 },
        new Pokemon {ID = 7, Name = "Squirtle", Type = "Water", Level =  15 },
        new Pokemon {ID = 25, Name = "Pikachu", Type = "Electric", Level =  15 },
        new Pokemon {ID = 471, Name = "Glaceon", Type = "Ice", Level =  46 }
   
   
    };

    var readyToEvolveQuery = from p in pokemon // p = Pokemon in the list
                            where p.Level >= 16
                            orderby p.Level
                            select p;
    //execute query and display the results
    Console.WriteLine("Pokemon Ready to evolve: ");
    foreach (var Pokemon in readyToEvolveQuery){
        Console.WriteLine($"Name: {Pokemon.Name}, Type: {Pokemon.Type}, Level: {Pokemon.Level}");
    }
}
};

class Pokemon {
    /*attibutes for the class
    attribute describe the object*/
    public int ID {get; set;}
    public string Name {get; set; }
    public string Type {get; set; }
    public int Level {get ; set; }
}//end class