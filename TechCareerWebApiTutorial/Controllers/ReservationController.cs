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
		public IActionResult Get()
		{
			var rooms = _context.Companies.Include(x => x.Rooms).ToList();
			return Ok(rooms);
		}
		[HttpPost]
		public IActionResult CreateRoomByCompany(Company company)
		{
			var room = _context.Companies.Include(x => x.Rooms).FirstOrDefault(y => y.Id == company.Id);
			if (room == null)
			{
				return NotFound();
			}
			
			_context.SaveChanges();

			return StatusCode(201, company);


		}
		[HttpPost]
		public IActionResult CreateClientByCompany(Room room)
		{
			var clients = _context.Clients.Include(x => x.Rooms).FirstOrDefault(y => y.Id == room.Id);

			if (clients == null)
			{
				return NotFound();
			}

			_context.SaveChanges();

			return StatusCode(201, clients);

		}

		[HttpPut("{id}")]
		public IActionResult RoomUpdate(int id, Room room)
		{
			if (id != room.Id)
			{
				return NotFound();
			}
			var rooms = _context.Rooms.FirstOrDefault(x => x.Id == id);

			if (rooms == null)
			{
				return NotFound();
			}
			rooms.Name = room.Name;
			rooms.AddDate = room.AddDate;

			_context.SaveChanges();
			return StatusCode(201, rooms);
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{

			var rooms = _context.Rooms.FirstOrDefault(x => x.Id == id);


			if (rooms == null)
			{
				return NotFound();
			}

			_context.Rooms.Remove(rooms);
			_context.SaveChanges();

			return Ok(rooms);
		}




	}
}
