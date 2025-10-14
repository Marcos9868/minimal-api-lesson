using minimal_api.Domain.Enums;

namespace minimal_api.Domain.DTOs
{
    public class AdministratorDTO
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Profile? Profile { get; set; }
    }
}