//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;
					
public class Program
{
    public Hero assassin;
	
    public void Main()
    {
        assassin = new Hero();
        
		
        assassin.health = 50;
        assassin.powerLevel = 10;
        assassin.armorLevel = 8;
        assassin.mana = 150;
        assassin.speed = 12;
        assassin.attackDMG = 15;
		
        
		Console.WriteLine(assassin.heroClass);
        Console.WriteLine("Health = " + assassin.health);
        Console.WriteLine("Power Level = " + assassin.powerLevel);
        Console.WriteLine("Armor Level = " + assassin.armorLevel);
        Console.WriteLine("Mana = " + assassin.mana);
        Console.WriteLine("Speed = " + assassin.speed);
        Console.WriteLine("Attack Damage = " + assassin.attackDMG);
    }
}

public class Hero {
    public int health;
    public int powerLevel;
    public int armorLevel;
    public int mana;
    public int speed;
    public int attackDMG;
    public string heroClass = "Assassin";
}