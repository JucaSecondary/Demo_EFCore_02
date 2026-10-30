using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Demo_EFCore_02.Models.Player
{
  public class PlayerForm
  {
    [HiddenInput]
    public int Id { get; set; }

    [MaxLength(50)]
    public required string LastName { get; set; }

    public required string FirstName { get; set; }

    [MaxLength(50)]
    public required string? NickName { get; set; }
  }
}