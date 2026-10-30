using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
  internal class RaceEntityConfiguration : IEntityTypeConfiguration<RaceEntity>
  {
    public void Configure(EntityTypeBuilder<RaceEntity> builder)
    {
      //Table
      builder.ToTable("Races");

      //Key
      builder.HasKey(r => r.Id)
      .HasName("PK_Races")
      .IsClustered();

      //Properties
      builder.Property(r => r.Id)
      .IsRequired()
      .ValueGeneratedOnAdd();

      builder.Property(r => r.Name)
      .HasMaxLength(30)
      .IsRequired();

      //Index
      builder.HasIndex(r => r.Name)
      .IsUnique()
      .HasDatabaseName("UK_Races_Name");

      builder.HasData(
        new RaceEntity() { Id = 1, Name = "Human" },
        new RaceEntity() { Id = 2, Name = "Monke" },
        new RaceEntity() { Id = 3, Name = "Elf" },
        new RaceEntity() { Id = 4, Name = "Half-elf" },
        new RaceEntity() { Id = 5, Name = "Clanker" },
        new RaceEntity() { Id = 6, Name = "Terran" },
        new RaceEntity() { Id = 7, Name = "Avian" },
        new RaceEntity() { Id = 8, Name = "Floran" },
        new RaceEntity() { Id = 9, Name = "Novakid" },
        new RaceEntity() { Id = 10, Name = "LeFishe" }
      );
    }
  }
}