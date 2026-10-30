using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
  internal class PlayerEntityConfiguration : IEntityTypeConfiguration<PlayerEntity>
  {
    public void Configure(EntityTypeBuilder<PlayerEntity> builder)
    {
      //Table
      builder.ToTable("Players");

      //Clef
      builder.HasKey(p => p.Id)
      .HasName("PK_Players")
      .IsClustered();

      //Colonnes
      builder.Property(p => p.Id)
      .ValueGeneratedOnAdd();

      builder.Property(p => p.FirstName)
      .HasMaxLength(50)
      .IsUnicode()
      .IsRequired();

      builder.Property(p => p.LastName)
      .HasColumnType("NVARCHAR(50)")//Pas automatique, ne supporte pas le changement
      .IsRequired();

      builder.Property(p => p.NickName)
      .HasMaxLength(50)
      .IsUnicode(false)
      .IsRequired(false);

      //Index
      builder.HasIndex(p => new { p.FirstName, p.LastName })
      .IsUnique()
      .HasDatabaseName("IDX_Players_Name");

      builder.HasData(
        new PlayerEntity { Id = 1, NickName = "PotatoRagi", FirstName = "Katrine", LastName = "Heiton" },
        new PlayerEntity { Id = 2, NickName = "VictoriousClovito", FirstName = "Kaleena", LastName = "MacGilmartin" },
        new PlayerEntity { Id = 3, NickName = "HirjiDisgusted", FirstName = "Gay", LastName = "Mc Faul" },
        new PlayerEntity { Id = 4, NickName = "PalladiumDysprosium", FirstName = "Nealy", LastName = "Danielsky" },
        new PlayerEntity { Id = 5, NickName = "SickLonely", FirstName = "Lorita", LastName = "Blumire" },
        new PlayerEntity { Id = 6, NickName = "AliveTurnip", FirstName = "Arleta", LastName = "Venables" },
        new PlayerEntity { Id = 7, NickName = "PotatoManil", FirstName = "Kimbell", LastName = "Tirte" },
        new PlayerEntity { Id = 8, NickName = "AliveMizuchi", FirstName = "Roobbie", LastName = "Rosekilly" },
        new PlayerEntity { Id = 9, NickName = "ToadValkyrie", FirstName = "Nita", LastName = "Dragon" },
        new PlayerEntity { Id = 10, NickName = "MoscoviumObnoxious", FirstName = "Olva", LastName = "Dukes" },
        new PlayerEntity { Id = 11, NickName = null, FirstName = "Leroy", LastName = "Jenkins" }
      );
    }
  }
}