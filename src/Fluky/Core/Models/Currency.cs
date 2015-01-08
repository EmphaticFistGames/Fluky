﻿namespace Fluky.Core.Models
{
  public class Currency
  {
    public Currency()
    {
    }

    public Currency(CurrencyCodeType codeType, string name)
    {
      CodeType = codeType;
      Name = name;
    }

    public CurrencyCodeType CodeType { get; set; }
    public string Name { get; set; }
  }
}
