using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace Interface
{
  public class Program
  {
    public static void Main()
    { 
      Console.WriteLine("Welcome To Pierre's Bakery"); 
      Console.WriteLine("My name is Pierre, may I take your order? [Y][N]");
      string orderAnswer = Console.ReadLine().ToLower();
      if (orderAnswer == "y")
      {
        Program.TakeOrder();

      }
      else
      {
        Console.WriteLine("Thank you for coming to Pierre's Bakery");
      }
    }

    public static void TakeOrder()
    {
      Console.WriteLine("Bread is $5.00 per loaf. Buy two and the 3rd loaf is FREE"); 
      Console.WriteLine("How many loaves of bread would you like to buy?"); 
      int bread = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(bread);

      Console.WriteLine("Pastries are $2.00 each. Buy two and the third one is just $1.00 (3 for $5.00");
      Console.WriteLine("How many pastries would you like to buy?"); 
      int pastries = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(pastries);
    }

    // public static void PrintOrder()
    // { 
    //   int breadQuant = breadOrder
    //   string breadWord = " loaves"; 
    //   string pastryWord = " pastries";
    //   string breadWordQuant = Program.Order["bread"].ToString();  
    //   string pastryWordQuant = Program.Order["pastries"].ToString();  

    //   if (Program.Order["bread"] == 1)
    //   {
    //     breadWord = " loaf"; 
    //   }
    //   if (Program.Order["pastries"] == 1)
    //   {
    //     pastryWord = " pastry";
    //   }
    //   Console.WriteLine("You have ordered " + breadQuant + breadWord + " of bread and " + pastryQuant + pastryWord);
    // }    
  }
}