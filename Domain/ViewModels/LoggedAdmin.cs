namespace minimal_api.Domain.ViewModels
{
    public record LoggedAdmin
    {
        public string Email { get; set; } = default!;
        public string Profile { get; set; } = default!;
        public string Token { get; set; } = default!;
    }
}