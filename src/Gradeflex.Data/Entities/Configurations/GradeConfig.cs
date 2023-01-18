using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class GradeConfig : IEntityTypeConfiguration<Grade>
{
    public void Configure(EntityTypeBuilder<Grade> builder)
    {
        builder.HasKey(grade => grade.Id);

        //builder.HasOne(grade => grade.CourseStudent)
        //    .WithMany(cs => cs.Grades)
        //    .HasForeignKey(grade => new { grade.CourseId, grade.StudentId });
    }
}
