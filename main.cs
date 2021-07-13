using System;

class MainClass {


  public static void Main (string[] args) {
    Console.WriteLine ("How many people parked in the garage ? ");
    int peopleParked = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The amount of people parked in garage is " + peopleParked);
    Console.WriteLine("Is there anymore ??");
    var choice = Console.ReadLine();

    if (choice == "no")
    {
     Console.WriteLine("Amount of people parked " + peopleParked); 
     
     for (int customers= 0; customers<peopleParked; customers++){
       Console.WriteLine("enter customers hrs");
       double customerParkedHrs = Console.ReadLine();
       Console.WriteLine(customerParkedHrs);
     }
    }
    else
    {
     Console.WriteLine("How many more people");
     int peopleParked2 = Convert.ToInt32(Console.ReadLine());
     int peopleParked3 = peopleParked2 + peopleParked;
        Console.WriteLine("Amount of people is parked " + peopleParked3);
     
    }
  }
public static double CalcualteCharges()
{
Console.WriteLine("enter the hours for each person parked");
double charges = Convert.ToDouble(Console.ReadLine());

  return charges;
}
}