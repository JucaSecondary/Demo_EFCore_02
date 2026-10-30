using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
  public class PlayerRepository : IRepositoryCRUD<PlayerEntity>
  {
    private DungeonDbContext _dbContext;

    public PlayerRepository(DungeonDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public IEnumerable<PlayerEntity> GetAll()
    {
      return _dbContext.Players.ToList();
    }
  }
}