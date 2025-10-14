using minimal_api.Application.Interfaces;
using minimal_api.Domain.DTOs;
using minimal_api.Domain.Entities;
using minimal_api.Infrastructure.Data;

namespace minimal_api.Application.Services
{
  public class AdministratorService : IAdministratorService
  {
    private readonly DataContext _context;
    public AdministratorService(DataContext context) => _context = context;
    public Admin? Login(LoginDTO login)
    {
      var adminQuantity = _context.Admins.FirstOrDefault(a => a.Email == login.Email);
      return adminQuantity;
    }
    public Admin AddAdmin(Admin admin)
    {
      _context.Admins.Add(admin);
      _context.SaveChanges();
      return admin;
    }
    public List<Admin> All(int? page)
    {
      var query = _context.Admins.AsQueryable();
      int itemsPerPage = 10;
      if (page != null)
        query = query.Skip(((int)page - 1) * itemsPerPage).Take(itemsPerPage);
      return query.ToList();
    }
    public Admin? SearchById(int id)
    {
      return _context.Admins.FirstOrDefault(a => a.Id == id);
    }
  }
}