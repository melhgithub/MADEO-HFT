using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class AdminHomePage : Controller
    {
        HomePageManager homepageManager = new HomePageManager(new EFHomePageRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());

        public async Task<IActionResult> Index()
        {
            var homepage = await homepageManager.GetList();
            var image = await imageManager.GetList();
            var filter = new HomePageEditDto();
            var model = new HomePageAdminViewModel
            {
                FilterDto = filter,
                HomePage = homepage,
                Images = image
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HomePageEditDto homepage)
        {
            try
            {
                var updatedPage = await homepageManager.GetByID(homepage.ID);
                if (updatedPage != null)
                {
                    updatedPage.Title = homepage.Title;
                    updatedPage.Title2 = homepage.Title2;
                    updatedPage.VideoLink = homepage.VideoLink;
                    updatedPage.Text1 = homepage.Text1;
                    if (homepage.Image1 != null)
                    {
                        int imageid = int.Parse(homepage.Image1);
                        var image = await imageManager.GetByID(imageid);
                        if(image.Name != updatedPage.Image1)
                        {
                            updatedPage.Image1 = image.Name;
                        }
                    }
                    if (homepage.Image2 == "null")
                    {
                        updatedPage.Image2 = null;
                    }
                    else if(homepage.Image2 != null && homepage.Image2 != "null")
                    {
                        int imageid = int.Parse(homepage.Image2);
                        var image = await imageManager.GetByID(imageid);
                        updatedPage.Image2 = image.Name;
                    }

                    if (homepage.Image3 == "null")
                    {
                        updatedPage.Image3 = null;
                    }
                    else if (homepage.Image3 != null && homepage.Image3 != "null")
                    {
                        int imageid = int.Parse(homepage.Image3);
                        var image = await imageManager.GetByID(imageid);
                        updatedPage.Image3 = image.Name;
                    }

                    if (homepage.Image4 == "null")
                    {
                        updatedPage.Image4 = null;
                    }
                    else if (homepage.Image4 != null && homepage.Image4 != "null")
                    {
                        int imageid = int.Parse(homepage.Image4);
                        var image = await imageManager.GetByID(imageid);
                        updatedPage.Image4 = image.Name;
                    }

                    if (homepage.Image5 == "null")
                    {
                        updatedPage.Image5 = null;
                    }
                    else if (homepage.Image5 != null && homepage.Image5 != "null")
                    {
                        int imageid = int.Parse(homepage.Image5);
                        var image = await imageManager.GetByID(imageid);
                        updatedPage.Image5 = image.Name;
                    }

                    await homepageManager.Update(updatedPage);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                var filter = new HomePageEditDto();
                return View("Index", new HomePageAdminViewModel
                {
                    FilterDto = filter,
                    HomePage = await homepageManager.GetList(),
                    Images = await imageManager.GetList()
                });
            }
            return RedirectToAction("Index");
        }
    }
}
