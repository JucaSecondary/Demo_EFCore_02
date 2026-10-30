using DAL.Entities;
using Demo_EFCore_02.Models;

namespace Demo_EFCore_02.Mappers
{
  public static class PlayerMapper
  {
    public static PlayerViewModel ToViewModel(this PlayerEntity playerEntity)
    {
      return new PlayerViewModel()
      {
        Id = playerEntity.Id,
        NickName = playerEntity.NickName,
        FirstName = playerEntity.FirstName,
        LastName = playerEntity.LastName,
      };
    }
  }
}