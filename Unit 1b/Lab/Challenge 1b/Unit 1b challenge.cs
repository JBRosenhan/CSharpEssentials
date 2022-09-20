// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.
using System;
					
public class Program
{
	public PowerUps currentPowerUps;
	
	public void Main()
	{
		currentPowerUps = new PowerUps();
		
		currentPowerUps.PowerUp("speed");
		currentPowerUps.PowerUp("health");
		currentPowerUps.PowerUp("damage");
		currentPowerUps.PowerUp("strength");
	}
}

public class PowerUps {
	
	public void PowerUp (string powerUp) {
	if(powerUp == "speed") {
		Console.WriteLine("Speed PowerUp activated");
	}else if(powerUp == "health") {
		Console.WriteLine("Health PowerUp Activated");
	}else if(powerUp == "damage") {
		Console.WriteLine("Damage PowerUp Activated");
	}else{
		Console.WriteLine("No PowerUp Detected");	
	}
	}
}