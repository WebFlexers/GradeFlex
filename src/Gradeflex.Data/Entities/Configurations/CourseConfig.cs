using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(course => course.Id);

        builder.Property(course => course.Title)
            .IsRequired(true)
            .HasMaxLength(60);

        builder.Property(course => course.Semester)
            .IsRequired(true)
            .HasMaxLength(25);

        
    }
}
