using System;

namespace Dealership.Models 
{
  public class Car
  {
    private string _makeModel;
    public int Price {get; set; }
    public int Miles {get; set; }
    public int Year {get; set; }
    public int ValuedPrice {get; set; }

    public string MakeModel
    {
      get
      {
        return _makeModel;
      }
      set
      {
        _makeModel = value;
      }
    }

    public Car(string makeModel, int price, int miles, int year, int valuedPrice)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Year = year; 
      ValuedPrice = valuedPrice;
    }

    public static string MakeSound(string sound) 
    {
      return "Our cars sound like" + sound;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public int GetYear()
    {
      return Year;
    }

    public int GetValuedPrice()
    {
      return ValuedPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}