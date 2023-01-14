using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class StudentConfig : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(student => student.RegistrationNumber);

        builder.Property(student => student.Name)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(student => student.Surname)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(student => student.Department)
            .IsRequired()
            .HasMaxLength(45);
    }
}
