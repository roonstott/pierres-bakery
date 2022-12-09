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
      Console.WriteLine("My name is Pierre, may I take your order? [Y/N]");
      string orderAnswer = Console.ReadLine().ToLower();
      if (orderAnswer == "y")
      {
        int[] order = Program.TakeOrder();
        Bread breadOrder = new Bread(order[0]);
        Pastry pastryOrder = new Pastry(order[1]);
        Program.PrintOrder(breadOrder, pastryOrder);
        string keepGoing = "y";
        while (keepGoing == "y")
        {
        Console.WriteLine("See what a great value we offer?? Would you like to add more items to your order? [Y/N] ");
        keepGoing = Console.ReadLine().ToLower();
        if (keepGoing == "y")
          {
            int[] changeOrder = Program.ReviseOrder(breadOrder, pastryOrder);
            breadOrder.NumberOfBread += changeOrder[0];
            pastryOrder.NumberOfPastry += changeOrder[1];
            Program.PrintOrder(breadOrder, pastryOrder);
          }
        }
        Program.PrintOrder(breadOrder, pastryOrder);        
      }
      else
      {
        Console.WriteLine("Thank you for coming to Pierre's Bakery");
      }
    }

    public static int[] TakeOrder()
    {
      Console.WriteLine("Bread is $5.00 per loaf. Buy two and the 3rd loaf is FREE"); 
      Console.WriteLine("How many loaves of bread would you like to buy?"); 
      int bread = int.Parse(Console.ReadLine());     
      Console.WriteLine("Pastries are $2.00 each. Buy two and the third one is just $1.00 (3 for $5.00");
      Console.WriteLine("How many pastries would you like to buy?"); 
      int pastries = int.Parse(Console.ReadLine());
      int[] order = {bread, pastries};
      return order;
    }

    public static void PrintOrder(Bread bread, Pastry pastry)
    {
      string breadWord = bread.LoafOrLoaves();
      string pastryWord = pastry.PastryOrPastries();
      string breadQuant = bread.NumberOfBread.ToString();
      string pastryQuant = pastry.NumberOfPastry.ToString();
      int totalPrice = pastry.ComputePrice() + bread.ComputePrice();
      string stringPrice = totalPrice.ToString();
      Console.WriteLine("You have ordered " + breadQuant + " " + breadWord + " of bread and " + pastryQuant + " " + pastryWord);
      Console.WriteLine("The total price for your order is $" + stringPrice + ".00");
    }

    public static int[] ReviseOrder(Bread bread, Pastry pastry)
    {
      string breadWord = bread.LoafOrLoaves();
      string pastryWord = pastry.PastryOrPastries();
      string breadQuant = bread.NumberOfBread.ToString();
      string pastryQuant = pastry.NumberOfPastry.ToString();
      string breadPrice = bread.ComputePrice().ToString();
      string pastryPrice = pastry.ComputePrice().ToString();

      Console.WriteLine("You've already ordered " + breadQuant + " " + breadWord + " of bread for $" + breadPrice +".00. How many more loaves of bread do you want to get??");
      int moreBread = int.Parse(Console.ReadLine());
      Console.WriteLine("You've already ordered " + pastryQuant + " " + pastryWord + " for $" + pastryPrice +".00. How many more pastries do you want to get??");
      int morePastry = int.Parse(Console.ReadLine());
      int [] orderUpdate = {moreBread, morePastry};
      return orderUpdate;
    }

  }
}