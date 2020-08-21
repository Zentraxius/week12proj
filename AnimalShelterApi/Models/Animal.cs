namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public int AdoptionFee { get; set; }
    public string AnimalName { get; set; }
    public string AnimalDescription { get; set; }
    public string AnimalHealth { get; set; }
    public string SuggestedHome { get; set; }
  }
}