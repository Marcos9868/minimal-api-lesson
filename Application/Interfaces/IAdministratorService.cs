using minimal_api.Domain.DTOs;
using minimal_api.Domain.Entities;

namespace minimal_api.Application.Interfaces
{
    public interface IAdministratorService
    {
        List<Admin> Login(LoginDTO login);        
    }
}