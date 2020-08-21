namespace AnimalShelterApi.Models
{
  public class Shelter
  {
    public int ShelterId {get;set;}
    public string Description {get;set;}
    public int Dogs {get;set;}
    public int Cats {get;set;}
    public string DogsDescription {get;set;}
    public string CatsDescription {get;set;}
  }
}