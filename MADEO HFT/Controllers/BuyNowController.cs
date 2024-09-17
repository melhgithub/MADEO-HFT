using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class BuyNowController : Controller
    {
        BuyNowManager buynowManager = new BuyNowManager(new EFBuyNowRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        BannerManager bannerManager = new BannerManager(new EFBannerRepository());
        LinkManager linkManager = new LinkManager(new EFLinkRepository());
        ProductManager productManager = new ProductManager(new EFProductRepository());

        public async Task<IActionResult> Index()
        {
            var buynow = await buynowManager.GetList();
            var images = await imageManager.GetList();
            var banners = await bannerManager.GetList();
            var links = await linkManager.GetList();
            var products = await productManager.GetList();

            var model = new BuyNowViewModel
            {
                BuyNow = buynow,
                Images = images,
                Banners = banners,
                Links = links,
                Products = products
            };


            return View(model);
        }
    }
}
