using System;
					
public class Program
{
	public void Main()
	{
		string[] champions = {"Nocturne", "Azir", "Pantheon"};
		Console.WriteLine(champions.Length);
		foreach(var champion in champions) {
			Console.WriteLine("I choose " + champion + " as my Champion.");
		}
	}
}