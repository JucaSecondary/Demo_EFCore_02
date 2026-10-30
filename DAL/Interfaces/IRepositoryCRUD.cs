namespace DAL.Interfaces
{
  public interface IRepositoryCRUD<EntityType>
  {
    IEnumerable<EntityType> GetAll();
  }
}