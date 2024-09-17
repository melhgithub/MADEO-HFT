using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EFProductRepository());
        LinkManager linkManager = new LinkManager(new EFLinkRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        BannerManager bannerManager = new BannerManager(new EFBannerRepository());
        public async Task<IActionResult> Index()
        {
            var products = await productManager.GetList();
            var links = await linkManager.GetList();
            var images = await imageManager.GetList();
            var banners = await bannerManager.GetList();

            var model = new ProductViewModel
            {
                Products = products,
                Links = links,
                Images = images,
                Banners = banners,
                ProductsTwo = products,
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ProductPreviews(int productID)
        {
            if(productID == null)
            {
                return RedirectToAction("Product");
            }
            else
            {
                try
                {
                    var product = await productManager.GetByID(productID);
                    if (product == null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        var products = await productManager.GetList();
                        products = products.Where(p=> p.ID == product.ID).ToList();
                        if (product != null)
                        {
                            var productstwo = await productManager.GetList();
                            var links = await linkManager.GetList();
                            var images = await imageManager.GetList();
                            var banners = await bannerManager.GetList();

                            var model = new ProductViewModel
                            {
                                Products = products,
                                Links = links,
                                Images = images,
                                Banners = banners,
                                ProductsTwo = productstwo
                            };
                            return View(model);
                        }
                        else
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception)
                {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
