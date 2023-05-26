using System;

//Automatic Properties(Short Hand )

public class GetSet
{
	public string Name
	{ get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		Program program = new Program();
		program.Name = "Chauhan";
		Console.WriteLine(program.Name);
	}
}
