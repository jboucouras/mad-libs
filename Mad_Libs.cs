using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program accomplishes the same thing as the PHP Mad Libs exercise, but this time, it has been done in C#. This concept was pulled from another Codecademy exercise, and demonstrates understanding of variables, data types, commands, and more. 
      Author: Jason Boucouras
      */



Console.WriteLine("Mad Libs is now starting!");

   
      string title = "My C# Story";

      Console.WriteLine(title);
      

			Console.Write("Enter any name here:");
      string name = Console.ReadLine();
      
      Console.Write("Enter an adjective here:");
        string adjective1 = Console.ReadLine();
      
      Console.Write("Enter another adjective here:");
      string adjective2 = Console.ReadLine();
      
      Console.Write("Please enter one last adjective here:");
      string adjective3 = Console.ReadLine();
      
      Console.Write("Enter a verb here:");
      string verb1 = Console.ReadLine();
      
      Console.Write("Enter a noun here:");
      string noun1 = Console.ReadLine();
      
      Console.Write("Please enter another noun here:");
      string noun2 = Console.ReadLine();
      
      Console.Write("Enter an animal here:");
      string animal1 = Console.ReadLine();
      
      Console.Write("Enter a food here:");
      string food1 = Console.ReadLine();
      
      Console.Write("Enter a fruit here:");
      string fruit1 = Console.ReadLine();
      
      Console.Write("Enter a superhero here:");
      string superhero1 = Console.ReadLine();
      
      Console.Write("Enter a country here:");
      string country1 = Console.ReadLine();
      
      Console.Write("Enter a dessert here:");
      string dessert1 = Console.ReadLine();
      
      Console.Write("Enter a year here:");
      string year1 = Console.ReadLine();
      

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal1}s were protesting to keep {food1} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit1}s very {adjective3}. Concerned, {name} texted {superhero1}, who flew {name} to {country1} and dropped {name} in a puddle of frozen {dessert1}. {name} woke up in the year {year1}, in a world where {noun2}s ruled the world.";


     
Console.WriteLine(story);
      
    }
  }
}
