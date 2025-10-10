using minimal_api.Domain.Entities;
using MinimalApi.DTOs;

namespace minimal_api.Application.Interfaces
{
    public interface IAdministratorService
    {
        List<Admin> Login(LoginDTO login);        
    }
}