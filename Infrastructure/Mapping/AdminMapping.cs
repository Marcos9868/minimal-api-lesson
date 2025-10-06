using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using minimal_api.Domain.Entities;

namespace minimal_api.Infrastructure.Mapping
{
  public class AdminMapping : IEntityTypeConfiguration<Admin>
  {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Email).HasMaxLength(150).IsRequired();
            builder.Property(a => a.Password).IsRequired();
    }
  }
}