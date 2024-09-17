using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MADEO_HFT.Controllers
{
    public class AdminBuyNow : Controller
    {
        BuyNowManager buynowManager = new BuyNowManager(new EFBuyNowRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        LinkManager linkManager = new LinkManager(new EFLinkRepository());
        public async Task<IActionResult> Index()
        {
            var buynow = await buynowManager.GetList();
            var image = await imageManager.GetList();
            var links = await linkManager.GetList();
            var filter = new BuyNowEditDto();
            var model = new BuyNowAdminViewModel
            {
                FilterDto = filter,
                Links = links,
                Images = image,
                Buynow = buynow,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(BuyNowEditDto buynow)
        {

            try
            {
                var updatedPage = await buynowManager.GetByID(buynow.ID);
                if (updatedPage != null)
                {
                    updatedPage.Title = buynow.Title;
                    updatedPage.Title2 = buynow.Title2;
                    updatedPage.Text = buynow.Text;
                    updatedPage.Text2 = buynow.Text2;

                    if (buynow.Resim1 != null)
                    {
                        int imageid = int.Parse(buynow.Resim1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedPage.Resim1)
                        {
                            updatedPage.Resim1 = image.Name;
                        }
                    }

                    await buynowManager.Update(updatedPage);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                var filter = new BuyNowEditDto();
                return View("Index", new BuyNowAdminViewModel
                {
                    FilterDto = filter,
                    Buynow = await buynowManager.GetList(),
                    Links = await linkManager.GetList(),
                    Images = await imageManager.GetList()
                });
            }
            return RedirectToAction("Index");
        }
    }
}
