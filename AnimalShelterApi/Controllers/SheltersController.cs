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
    public ActionResult<IEnumerable<Shelter>> GetAction(string username, int rating, string country)
    {
      var query = _db.Shelters.AsQueryable();

      if (username != null)
      {
        query = query.Where(entry => entry.UserName == username);
      }
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if (rating != 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Shelter shelter)
    {
      _db.Shelters.Add(shelter);
      _db.SaveChanges();
    }
    [HttpGet("rating/best")]
    public ActionResult<IEnumerable<Shelter>> GetBestRating()
    {
      var query = _db.Shelters.OrderByDescending(entry => entry.Rating);
      return query.ToList();
    }

    [HttpGet("rating/worst")]
    public ActionResult<IEnumerable<Shelter>> GetWorstRating()
    {
      var query = _db.Shelters.OrderBy(entry => entry.Rating);
      return query.ToList();
    }

    [HttpGet("pages/")] // Pagination
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.Shelters
        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
        .Take(validFilter.PageSize)
        .ToListAsync();
      var totalRecords = await _db.Shelters.CountAsync();
      return Ok(new PagedResponse<List<Shelter>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    [HttpGet("{id}")] // Pagination
    public async Task<IActionResult> GetById(int id)
    {
      var shelter = await _db.Shelters.Where(a => a.ShelterId == id).FirstOrDefaultAsync();
      return Ok(new Response<Shelter>(shelter));
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shelter shelter)
    {
      shelter.ShelterId = id;
      _db.Entry(shelter).State = EntityState.Modified;
      _db.SaveChanges();
    }


    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shelterToDelete = _db.Shelters.FirstOrDefault(entry => entry.ShelterId == id);
      _db.Shelters.Remove(shelterToDelete);
      _db.SaveChanges();
    }
  }
}