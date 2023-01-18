using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class CourseStudentConfig : IEntityTypeConfiguration<CourseStudent>
{
    public void Configure(EntityTypeBuilder<CourseStudent> builder)
    {
        builder.HasKey(cs => new { cs.CourseId, cs.StudentId });
    }
}
