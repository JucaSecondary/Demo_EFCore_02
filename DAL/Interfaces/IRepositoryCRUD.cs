namespace DAL.Interfaces
{
  public interface IRepositoryCRUD<EntityType>
  {
    EntityType? GetById(int id);

    IEnumerable<EntityType> GetAll();
  }
}