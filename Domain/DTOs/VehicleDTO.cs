namespace minimal_api.Domain.DTOs
{
    public class VehicleDTO
    {
        public string Name { get; set; } = string.Empty;
        public string VehicleMark { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }       
    }
}