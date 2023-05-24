using BethanysPieShop.Models.Repositories;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers;

public class HomeController : Controller
{
    private readonly IPieRepository _pieRepository;

    public HomeController(IPieRepository pieRepository)
    {
        _pieRepository = pieRepository;
    }

    public ViewResult Index()
    {
        var piesOfTHeWeek = _pieRepository.PiesOfTheWeek;
        var homeViewModel = new HomeViewModel(piesOfTHeWeek);
        return View(homeViewModel);
    }
}