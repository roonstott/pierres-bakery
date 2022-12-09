using System;
using System.Collections.Generic;


namespace PierresBakery.Models
{
  public class Bread
  {
    
    public int NumberOfBread { get; }

    public Bread( int numberOfBread ) 

    {
      NumberOfBread = numberOfBread;
    }

    public int ComputePrice() 
    {
      int remainder = NumberOfBread % 3;
      int groupsOfThree = (NumberOfBread-remainder)/3;
      return (groupsOfThree * 10) + (remainder * 5);
    }

    public string LoafOrLoaves()
    {
      if (NumberOfBread == 1)
      {
        return "loaf";
      }
      else
      {
        return "loaves";
      }
    }

  }

  public class Pastry
  {

    public int NumberOfPastry { get; }
    public Pastry ( int numberOfPastry)
    {
      NumberOfPastry = numberOfPastry;
    }

    public int ComputePrice() 
    {
      int remainder = NumberOfPastry % 3;
      int groupsOfThree = (NumberOfPastry-remainder)/3;
      return (groupsOfThree * 5) + (remainder * 2);
    }

  }

}
