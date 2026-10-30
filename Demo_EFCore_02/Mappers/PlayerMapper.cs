using DAL.Entities;
using Demo_EFCore_02.Models.Player;

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

    public static PlayerEntity ToEntity(this PlayerForm playerForm)
    {
      return new PlayerEntity()
      {
        Id = playerForm.Id, //Mettre à la valeur par défaut si non modifié dans la configuration par .HasSentinel
        NickName = playerForm.NickName,
        FirstName = playerForm.FirstName,
        LastName = playerForm.LastName,
      };
    }

    public static PlayerForm ToForm(this PlayerViewModel playerViewModel)
    {
      return new PlayerForm()
      {
        Id = playerViewModel.Id,
        FirstName = playerViewModel.FirstName,
        LastName = playerViewModel.LastName,
        NickName = playerViewModel.NickName,
      };
    }
  }
}