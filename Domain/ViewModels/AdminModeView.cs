namespace minimal_api.Domain.ViewModels
{
    public record AdminModeView
    {
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Profile { get; set; } = default!; 
    }
}