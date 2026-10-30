namespace Demo_EFCore_02.Models
{
  public class PlayerViewModel
  {
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string? NickName { get; set; }
  }
}