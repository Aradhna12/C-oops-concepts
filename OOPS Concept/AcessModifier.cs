using System;

public class AcessModifier
{

    public int state ;
 }

public class Modifier
{
    private string cityNo;
    static void Main(string[] args)
    {
        AcessModifier obj = new AcessModifier();
        Modifier obj1 = new Modifier();
        obj.state = "Gurgaon";
        obj1.city = 4;

        Console.Writeline(obj.state);
        Console.Writeline(obj1.city);

    }
   
}
