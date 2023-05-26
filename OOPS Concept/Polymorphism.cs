using System;

class Polymorphism
{
	public virtual void animalSound()
	{
        Console.WrtieLine("The animal makes sound");
    }
	                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
}
class Dog: Polymorphism
{
      public override void animalSound()
    {
        Console.WrtieLine("The dog says: bow bow");
    }

}

class Pig : Polymorphism
{
    public override void animalSound()
    {
        Console.WrtieLine("The pig says: wee wee");
    }
    public static void Main(string[] args)
    {
        Polymorphism polymorphism = new Polymorphism();
        Pig pig = new Pig();    
        Dog dog = new Dog();    

        polymorphism.animalSound(); 
        dog.animalSound();
        pig.animalSound();  
    }
}

class program
{

}



