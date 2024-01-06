using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using TechCareerWebApiTutorial.Migrations;
using TechCareerWebApiTutorial.Models;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class ReservationController : ControllerBase
	{
		private readonly TechCareerDbContext _context;

		public ReservationController()
		{
			_context = new TechCareerDbContext();
		}

		[HttpGet]
		public IActionResult GetCompany()
		{
			var rooms = _context.Companies.Include(x => x.Rooms).ToList();
			return Ok(rooms);
		}

		[HttpPost]
		public IActionResult CreateRoom(Room room)
		{
			 _context.Rooms.Add(room);
			_context.SaveChanges();
			return StatusCode(201, room);
		}

		[HttpPut("{id}")]
		public IActionResult RoomUpdate(int id, Company company)
		{
			if (id != company.Id)
			{
				return NotFound();
			}
			var companies = _context.Companies.FirstOrDefault(x => x.Id == id);

			if (companies == null)
			{
				return NotFound();
			}
			companies.Name = company.Name;
			companies.Address = company.Address;
			companies.AddDate = company.AddDate;
			companies.UpdateDate = company.UpdateDate;

			_context.SaveChanges();
			return StatusCode(201, companies);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{

			var companies = _context.Companies.FirstOrDefault(x => x.Id == id);


			if (companies == null)
			{
				return NotFound();
			}

			_context.Companies.Remove(companies);
			_context.SaveChanges();

			return Ok(companies);
		}




	}
}
