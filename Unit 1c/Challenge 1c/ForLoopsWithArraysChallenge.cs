using System;
					
public class Program
{
	public static void Main()
	{
		string[] pokemonParty = {"Charmander", "Squirtle", "Bulbasaur"};
		
		for (var c = 0; c < 1 ; c++) {
		pokemonParty[c] = "Charmeleon";
		}
		for (var s = 1; s < 2 ; s++) {
		pokemonParty[s] = "Warturtle";
		}
		for (var b = 2; b < 3 ; b++) {
		pokemonParty[b] = "Ivysaur";
		}
		foreach(var pokemon in pokemonParty) {
			Console.WriteLine(pokemon);	
		}
	}
}