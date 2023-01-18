using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired(true)
            .HasMaxLength(60);

        builder.Property(course => course.Semester)
            .IsRequired(true)
            .HasMaxLength(25);
    }
}
