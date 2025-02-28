using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EternaApp.Models;
using Microsoft.EntityFrameworkCore;
using EternaApp.Data;
using EternaApp.ViewModels;

namespace EternaApp.Controllers;

public class HomeController : Controller
{
    
    private readonly EternaAppContext _context;

    public HomeController(EternaAppContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var homeSliders = _context.HomeSliders.ToList();
        var features= _context.Features.ToList();
        var services = _context.Services.ToList();
        var clients = _context.Clients.ToList();

        HomeVm homeVm = new HomeVm
        {
            homeSliders = homeSliders,
            Features = features,
            Services=services,
            Clients=clients

        };
        return View(homeVm);
    }


}