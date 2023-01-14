using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class SecretaryConfig : IEntityTypeConfiguration<Secretary>
{
    public void Configure(EntityTypeBuilder<Secretary> builder)
    {
        builder.HasKey(secretary => secretary.PhoneNumber);

        builder.Property(secretary => secretary.Name)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(secretary => secretary.Surname)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(secretary => secretary.Department)
            .IsRequired()
            .HasMaxLength(45);
    }
}
