using DAL.Entities;
using DAL.Interfaces;
using Demo_EFCore_02.Mappers;
using Demo_EFCore_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_EFCore_02.Controllers
{
  public class PlayerController : Controller
  {
    private IRepositoryCRUD<PlayerEntity> _playerRepository;

    public PlayerController(IRepositoryCRUD<PlayerEntity> playerRepository)
    {
      _playerRepository = playerRepository;
    }

    public IActionResult Index()
    {
      IEnumerable<PlayerViewModel> players = _playerRepository.GetAll().Select(PlayerMapper.ToViewModel);
      return View(players);
    }

    public IActionResult Details(int id)
    {
      PlayerViewModel? player = _playerRepository.GetById(id)?.ToViewModel();
      if (player == null) return NotFound();
      //On pourrait lancer une exception mais il faudrait ajouter un handler à notre application
      return View(player);
    }
  }
}