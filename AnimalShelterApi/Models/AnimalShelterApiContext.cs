using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
    : base(options)
    {

    }
    public DbSet<Animal> Animals { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, AdoptionFee = 0, AnimalName = "Toby", AnimalDescription = "Chonky Boi", AnimalHealth = "Healthy, all shots take care of, neutered!", SuggestedHome = "Toby is great with kids and an active environment, is also able to relax comfortably by himself or with cats, is afraid of other dogs." },
        new Animal { AnimalId = 2, AdoptionFee = 50, AnimalName = "Gabe", AnimalDescription = "Discount Garfield", AnimalHealth = "Healthy, all shots take care of, neutered!", SuggestedHome = "Gabe mostly just sleeps, anywhere quiet without young children or dogs is preferred." },
        new Animal { AnimalId = 3, AdoptionFee = 250, AnimalName = "Yeet", AnimalDescription = "Camera Blur", AnimalHealth = "Healthy, all shots take care of, neutered!", SuggestedHome = "Yeet is great with anyone who's high energy, terrorizes children." },
        new Animal { AnimalId = 4, AdoptionFee = 1000, AnimalName = "Xander", AnimalDescription = "Very friendly when asleep in the other room", AnimalHealth = "Afraid to check", SuggestedHome = "Xander is the best. Really. He doesn't bite at all. I was born with 9 fingers." },
        new Animal { AnimalId = 5, AdoptionFee = 250000000, AnimalName = "He-Who-Sleeps", AnimalDescription = "I can't remember", AnimalHealth = "Unknown", SuggestedHome = "Somewhere with alot of room and sacrifi- an influx of new faces daily." }
      );
    }
  }
}