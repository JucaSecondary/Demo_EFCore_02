namespace DAL.Exceptions
{
  [Serializable]
  internal class EntityNotFoundException : Exception
  {
    private Type _entityType;
    private string _propertyName;
    private int _propertyValue;

    public EntityNotFoundException()
    {
    }

    public EntityNotFoundException(string? message) : base(message)
    {
    }

    public EntityNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public EntityNotFoundException(Type entityType, string propertyName, int propertyValue) :
    base(message: $"Entity of type {entityType.Name} was not found where {propertyName} = '{propertyValue}'")
    {
      _entityType = entityType;
      _propertyName = propertyName;
      _propertyValue = propertyValue;
    }
  }
}