using System;

public class Constructor
{
    public string model;
    public string color;
    public int year;
    public int month;

    public Constructor(string modelName, string modelColor, int modelYear, int modelMonth)
    {
        model = modelName;  
        color = modelColor;
        year = modelYear;
        month = modelMonth;

        static void Main(string[] args)
        {
            Constructor car = new Constructor(Mustang,Green,2022,September); 
            Constructor car1 = new Constructor(Safari , Black, 2021 ,July)
                Console.WriteLine(car.model + " " + car.color + " " + car.year + " " + car.month );
            Console.WriteLine(car1.model + " " + car1.color + " " + car1.year + " " + car1.month);
        }
    }



}
