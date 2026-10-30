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

    public PlayerEntity? GetById(int id)
    {
      return _dbContext.Players.SingleOrDefault(p => p.Id == id);
    }

    public IEnumerable<PlayerEntity> GetAll()
    {
      return _dbContext.Players.ToList();
    }
  }
}