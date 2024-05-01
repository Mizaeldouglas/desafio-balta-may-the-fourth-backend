﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarWars.API.Models;

namespace StarWars.API.Storages.Datas.EntityConfigurations;

public class PlanetConfiguration : IEntityTypeConfiguration<PlanetModel>
{
    public void Configure(EntityTypeBuilder<PlanetModel> builder)
    {
        builder.ToTable("planets");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Name)
            .HasColumnName("name");

        builder.Property(x => x.RotationPeriod)
            .HasColumnName("rotationPeriod");

        builder.Property(x => x.OrbitalPeriod)
            .HasColumnName("orbitalPeriod");

        builder.Property(x => x.Diameter)
            .HasColumnName("diameter");

        builder.Property(x => x.Climate)
            .HasColumnName("climate");

        builder.Property(x => x.Gravity)
            .HasColumnName("gravity");

        builder.Property(x => x.Terrain)
            .HasColumnName("terrain");

        builder.Property(x => x.SurfaceWater)
            .HasColumnName("surfaceWater");

        builder.Property(x => x.Population)
            .HasColumnName("population");

        builder.Ignore(x => x.Characters);
        builder.Ignore(x => x.Movies);
    }
}
