using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    [AllowAnonymous]
    public class TechnologyController : Controller
    {
        Technology1Manager technology1Manager = new Technology1Manager(new EFTechnology1Repository());
        Technology2Manager technology2Manager = new Technology2Manager(new EFTechnology2Repository());
        Technology3Manager technology3Manager = new Technology3Manager(new EFTechnology3Repository());
        ProductManager productManager = new ProductManager(new EFProductRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        public async Task<IActionResult> Index(int techID)
        {
            var products = await productManager.GetList();
            var image = await imageManager.GetList();

            //var technology1 = techID == 1 ? await technology1Manager.GetList() : null;
            //var technology2 = techID == 2 ? await technology2Manager.GetList() : null;
            //var technology3 = techID == 3 ? await technology3Manager.GetList() : null;

            var technology1 = await technology1Manager.GetList();
            var technology2 = await technology2Manager.GetList();
            var technology3 = await technology3Manager.GetList();

            var filter = new TechnologyEditDto();

            var model = new TechnologyViewModel
            {
                Products = products,
                Technology1 = technology1,
                Technology2 = technology2,
                Technology3 = technology3,
                Images = image,
                FilterDto = filter
            };

            ViewBag.TechID = techID;

            return View(model);
        }

    }
}
