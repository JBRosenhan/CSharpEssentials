//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

using System;
					
public class Program
{
    public Hero heroOne;
    public Hero heroTwo;
	
    public void Main()
    {
        heroOne = new Hero();
        heroTwo = new Hero();
		
        heroOne.health = 2;
        heroOne.powerLevel = 5;
        heroOne.armorLevel = 10;
        heroOne.mana = 100;
		
        heroTwo.health = 3;
        heroTwo.powerLevel = 1;
        heroTwo.armorLevel = 4;
        heroTwo.mana = 150;
		
        Console.WriteLine(heroOne.health);
        Console.WriteLine(heroOne.powerLevel);
        Console.WriteLine(heroOne.armorLevel);
        Console.WriteLine(heroOne.mana);
		
        Console.WriteLine(heroTwo.health);
        Console.WriteLine(heroTwo.powerLevel);
        Console.WriteLine(heroTwo.armorLevel);
        Console.WriteLine(heroTwo.mana);
    }
}

public class Hero {
    public int health;
    public int powerLevel;
    public int armorLevel;
    public int mana;
}//Based on the HelloWorld File, turn this into a class.