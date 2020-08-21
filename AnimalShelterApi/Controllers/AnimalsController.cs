using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AnimalShelterApi.Wrappers;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SheltersController : ControllerBase
  {
    private AnimalShelterApiContext _db;
    public SheltersController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Animal>> GetAction(string animalname, int adoptionfee, string animaldescription)
    {
      var query = _db.Animals.AsQueryable();

      if (animalname != null)
      {
        query = query.Where(entry => entry.AnimalName == animalname);
      }
      if (animaldescription != null)
      {
        query = query.Where(entry => entry.AnimalDescription == animaldescription);
      }
      if (adoptionfee != 0)
      {
        query = query.Where(entry => entry.AdoptionFee == adoptionfee);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }
    [HttpGet("adoptionfee/highest")]
    public ActionResult<IEnumerable<Animal>> GetBestAdoptionFee()
    {
      var query = _db.Animals.OrderByDescending(entry => entry.AdoptionFee);
      return query.ToList();
    }

    [HttpGet("adoptionfee/lowest")]
    public ActionResult<IEnumerable<Animal>> GetWorstAdoptionFee()
    {
      var query = _db.Animals.OrderBy(entry => entry.AdoptionFee);
      return query.ToList();
    }

    [HttpGet("pages/")] // Pagination
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.Animals
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await _db.Animals.CountAsync();
      return Ok(new PagedResponse<List<Animal>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    [HttpGet("{id}")] // Pagination
    public async Task<IActionResult> GetById(int id)
    {
      var animal = await _db.Animals.Where(a => a.AnimalId == id).FirstOrDefaultAsync();
      return Ok(new Response<Animal>(animal));
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }


    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}