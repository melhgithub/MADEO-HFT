using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MADEO_HFT.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        HomePageManager homepageManager = new HomePageManager(new EFHomePageRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        BannerManager bannerManager = new BannerManager(new EFBannerRepository());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var homepage = await homepageManager.GetList();
            var images = await imageManager.GetList();
            var banners = await bannerManager.GetList();

            var model = new HomePageViewModel
            {
                HomePage = homepage,
                Images = images,
                Banners = banners
            };
            

            return View(model);
        }
    }
}
