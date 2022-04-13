using System;

public class SoldeZeroError : Exception
{
  public SoldeZeroError(string message): base(message)
  {}
  
}
