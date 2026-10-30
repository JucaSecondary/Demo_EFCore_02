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
    }
  }
}