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
      return NumberOfBread * 5;
    }

  }

  public class Pastry
  {

    public int NumberOfPastry { get; }
    public Pastry ( int numberOfPastry)
    {
      NumberOfPastry = numberOfPastry;
    }

  }

}
