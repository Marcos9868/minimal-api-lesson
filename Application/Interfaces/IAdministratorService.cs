using minimal_api.Domain.DTOs;
using minimal_api.Domain.Entities;

namespace minimal_api.Application.Interfaces
{
    public interface IAdministratorService
    {
        Admin? Login(LoginDTO login);
        Admin AddAdmin(Admin admin);
        Admin? SearchById(int id);
        List<Admin> All(int? page);
    }
}