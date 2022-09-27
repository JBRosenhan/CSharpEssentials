using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Corvette", "Stealth", "Supra", "Viper", "GTR", "Bentley"};
		Console.WriteLine(cars.Length);
		foreach(var car in cars) {
			Console.WriteLine("I Love My " + car + ".");
		}
	}
}