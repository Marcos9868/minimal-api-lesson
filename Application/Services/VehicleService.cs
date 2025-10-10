using Microsoft.EntityFrameworkCore;
using minimal_api.Application.Interfaces;
using minimal_api.Domain.Entities;
using minimal_api.Infrastructure.Data;

namespace minimal_api.Application.Services
{
	public class VehicleService : IVehicleService
	{
		private readonly DataContext _context;
		public VehicleService(DataContext context) => _context = context;
		public Vehicle AddVehicle(Vehicle vehicle)
		{
			_context.Vehicles.Add(vehicle);
			_context.SaveChanges();
			return vehicle;
		}
		public List<Vehicle> AllVehicles(int page, string? vehicleMark = null, string? name = null)
		{
			var query = _context.Vehicles.AsQueryable();
			if (!string.IsNullOrEmpty(name))
				query = query.Where(v => EF.Functions.Like(v.Name.ToLower(), $"%{name}%"));

			int itemsPerPage = 10;
			query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
			return [.. query];
		}
		public Vehicle GetById(int id)
		{
			return _context.Vehicles.FirstOrDefault(v => v.Id == id) ?? throw new Exception();
		}
		public void Remove(int id)
		{
			var vehicle = _context.Vehicles.Find(id) ?? throw new Exception();
			_context.Vehicles.Remove(vehicle);
			_context.SaveChanges();
		}
		public Vehicle Update(Vehicle vehicle)
		{
			throw new NotImplementedException();
		}
	}
}