namespace DAL.Interfaces
{
  public interface IRepositoryCRUD<EntityType>
  {
    int Create(EntityType data);

    EntityType? GetById(int id);

    IEnumerable<EntityType> GetAll();

    bool Update(int id, EntityType data);

    bool Delete(int id);
  }
}