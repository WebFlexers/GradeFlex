using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.Property(user => user.Username)
            .IsRequired(true)
            .HasMaxLength(45);

        builder.Property(user => user.Password)
            .IsRequired(true)
            .HasMaxLength(100);

        builder.Property(user => user.Role)
            .IsRequired(true)
            .HasMaxLength(45);

        builder.HasIndex(user => user.Username)
            .IsUnique();
    }

}
