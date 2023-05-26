using System;

public class Inheritance
{
	public void eat()
	{
		Conosle.WriteLine("Eating");
	}
}
public class Dog: Inheritance
{
	public void bark()
	{
		Console.WriteLine("Barking");
	}
}


public class BabyDog: Dog
{
	public void weep()
	{
		Console.WriteLine("Weeping")
	}
}
class Test
{
	public static void Main(string[] args)
	{
		BabyDog d1 = new BabyDog();	
		d1.eat();
		d1.bark();
		d1.weep();
	}
}
 
// Sealed class

//sealed class Vehicle
//{
//	Console.Writeline("This is sealed class");
//}

//class Car : Vehicle
//{
//	Console.WriteLine("Car is Vehicle");
//}

