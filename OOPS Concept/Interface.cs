using System;

abstract class Abstract

{
	public abstract void animalSound();
	public void sleep()
	{
		Console.WriteLine("Zzzzz");
	}
}

class Pig : Abstract
{
	public override void animalSound()
	{
		Console.WriteLine("The pig says:wee");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Pig p = new Pig();
		p.animalSound();
		p.sleep();
	}
}

//Interface Implementation


interface IAnimal
{
	void animalSound()
}

class Pig: IAnimal
{
	public void animalSound()
	{
		Console.WriteLine("The pig says: wee wee");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Pig p = new Pig();
		p.animalSound();
		
	}

}