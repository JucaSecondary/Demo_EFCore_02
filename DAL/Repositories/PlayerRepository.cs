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

    public int Create(PlayerEntity data)
    {
      var result = _dbContext.Players.Add(data);
      _dbContext.SaveChanges();
      return result.Entity.Id;
    }

    public bool Update(int id, PlayerEntity data)
    {
      //TODO: Vérifier si le joueur d'id `id` existe
      PlayerEntity dataForUpdate = new()
      {
        Id = id,
        NickName = data.NickName,
        FirstName = data.FirstName,
        LastName = data.LastName,
      };
      _dbContext.Update(dataForUpdate);
      _dbContext.SaveChanges();
      return true;
    }
  }
}