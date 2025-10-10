using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using minimal_api.Domain.Entities;

namespace minimal_api.Infrastructure.Mapping
{
  public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
  {
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
      builder.HasKey(v => v.Id);
      builder.Property(v => v.Name).HasMaxLength(100).IsRequired();
      builder.Property(v => v.VehicleMark).HasMaxLength(100).IsRequired();
      builder.Property(v => v.ReleaseYear).HasMaxLength(4).IsRequired();
    }
  }
}