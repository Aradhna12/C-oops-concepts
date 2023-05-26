using System;

class Properties
{
	private string name;

	public string Name;
	{
		get { return name; }
		set { name = value; }
	}
}

class Person
{
	static void Main(string[] args)
	{
		Properties p = new Properties();
		p.name = "Aradhna";
		Console.WriteLine(p.Name);
	}
}




       

