using DAL.Configs;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
  public class DungeonDbContext : DbContext
  {
    #region Properties

    public DbSet<PlayerEntity> Players { get; set; }

    #endregion Properties

    #region Constructors

    //Constructeur avec les options (via injection de dépendance)
    public DungeonDbContext(DbContextOptions options) : base(options) { }

    #endregion Constructors

    #region Methods

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      //modelBuilder.ApplyConfigurationsFromAssembly(typeof(DungeonDbContext).Assembly);
      //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
      modelBuilder.ApplyConfiguration(new PlayerEntityConfiguration());
      //TODO: Ne pas oublier d'ajouter la config pour les autres tables
    }

    #endregion Methods
  }
}