using DAL.Entities;
using DAL.Interfaces;
using Demo_EFCore_02.Mappers;
using Demo_EFCore_02.Models.Player;
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

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(PlayerForm playerForm)
    {
      if (!ModelState.IsValid)
        return View(playerForm);
      var returnId = _playerRepository.Create(playerForm.ToEntity());
      //TODO: faire un message pour l'utilisateur: "Joueur taratata créé avec succès"
      return RedirectToAction(nameof(Details), new { Id = returnId });
    }

    public IActionResult Edit(int id)
    {
      PlayerViewModel? player = _playerRepository.GetById(id)?.ToViewModel();
      if (player == null) return NotFound();

      return View(player.ToForm());
    }

    [HttpPost]
    public IActionResult Edit(int id, PlayerForm playerForm)
    {
      if (!ModelState.IsValid)
        return View(playerForm);
      _playerRepository.Update(id, playerForm.ToEntity());

      return RedirectToAction(nameof(Details), new { Id = id });
    }
  }
}