using System;

public class Members
{
	string color;
	int maxspeed;
	public void fullThrottle()
	{
		Console.WriteLine("The car is going fast");
	}
	static void Main(string[] args)
	{
		Members members1 = new Members();
		members1.fullThrottle();
		members1.color = "Blue";
		members1.maxspeed = 100;

		Console.WriteLine(members1.color);
		Console.WriteLine(members1.maxspeed);
	}
}
