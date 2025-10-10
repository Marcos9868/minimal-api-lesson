using minimal_api.Application.Interfaces;
using minimal_api.Domain.Entities;
using minimal_api.Infrastructure.Data;
using MinimalApi.DTOs;

namespace minimal_api.Application.Services
{
  public class AdministratorService : IAdministratorService
  {
        private readonly DataContext _context;
        public AdministratorService(DataContext context) => _context = context;
        public List<Admin> Login(LoginDTO login)
        {
            var adminQuantity = _context.Admins.Where(a => a.Email == login.Email);
            return adminQuantity.ToList();
        }
  }
}