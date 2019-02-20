using System.Collections.Generic;


namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _rest;
    private static List<Pet> _petList  = new List<Pet> {};
    private int _id;
    private bool _isAlive;

    public Pet (string name, int food, int attention, int rest)
    {
      _name = name;
      _food = food;
      _attention = attention;
      _rest = rest;
      _petList.Add(this);
      _id = _petList.Count;
      _isAlive = true;
    }

    public string isAlive()
    {
      if(_isAlive == true)
      {
        return "Alive";
      }else
      {
        return "Dead";
      }
    }

    public string GetName()
    {
      return _name;
    }

    public int GetFood()
    {
      return _food;
    }

    public int AddFood()
    {
      if(_food >= 100){
        _food = 100;
      } else {
        _food = _food + 5;
      }
      return _food;
    }

    public int GetAttention()
    {
      return _attention;
    }

    public int AddAttention()
    {
      if(_attention >= 100){
        _attention = 100;
      } else {
        _attention = _attention + 5;
      }
      return _attention;
    }

    public int GetRest()
    {
      return _rest;
    }

    public int AddRest()
    {
      if(_rest >= 100){
        _rest = 100;
      } else {
        _rest = _rest + 5;
      }
      return _rest;
    }

    public void TimePass(){
      if(_food <= 0 || _rest <= 0 || _attention <= 0){
        _food = 0;
        _rest = 0;
        _attention = 0;
      } else {
      _food = _food - 10;
      _rest = _rest - 10;
      _attention = _attention - 10;
    }
    }

    public void Delete(int id){
      _petList.RemoveAt(id-1);
    }

    public static List<Pet> GetAll()
    {
      return _petList;
    }

    public static void ClearAll()
    {
      _petList.Clear();
    }

    public static Pet Find(int searchId)
    {
      return _petList[searchId-1];
    }

    public int GetId()
   {
     return _id;
   }
  }
}
