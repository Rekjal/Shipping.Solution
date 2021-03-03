using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public int Height { get; set; }
    private int _length { get; set; }
    private int _depth { get; set; }
    private int _weight { get; set; }
    private int _cost { get; set; }
  
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(int height, int length, int depth, int weight)
    {
      Height = height;
      _length = length;
      _depth = depth;
      _weight = weight;
      _instances.Add(this);
    }

    public Parcel(int height, int length, int depth, int weight, int cost)
      : this (height, length, depth, weight)
    {
      _cost = cost;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
    
    public int CalcVolume()
    {
      return Height * _length * _depth;
    
    }

    public int CostToShip()
    {
      return _cost * 10;
    }
  }
}