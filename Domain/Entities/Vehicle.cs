namespace minimal_api.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VehicleMark { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }     
    }
}