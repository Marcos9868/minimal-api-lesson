using minimal_api.Domain.Entities;

namespace minimal_api.Application.Interfaces
{
    public interface IVehicleService
    {
        List<Vehicle> AllVehicles(int page, string? vehicleMark = null, string? name = null);
        Vehicle GetById(int id);
        Vehicle AddVehicle(Vehicle vehicle);
        Vehicle Update(Vehicle vehicle);
        void Remove(int id);
    }
}