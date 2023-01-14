﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gradeflex.Data.Entities.Configurations;

public class ProfessorConfig : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.HasKey(prof => prof.Afm);

        builder.Property(prof => prof.Name)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(prof => prof.Surname)
            .IsRequired()
            .HasMaxLength(45);

        builder.Property(prof => prof.Department)
            .IsRequired()
            .HasMaxLength(45);
    }
}
