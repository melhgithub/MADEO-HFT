using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.ViewComponents.Header
{
    public class Header : ViewComponent
    {
        LinkManager linkManager = new LinkManager(new EFLinkRepository());
        Technology1Manager technology1Manager = new Technology1Manager(new EFTechnology1Repository());
        Technology2Manager technology2Manager = new Technology2Manager(new EFTechnology2Repository());
        Technology3Manager technology3Manager = new Technology3Manager(new EFTechnology3Repository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var link = await linkManager.GetList();
            var technology1 = await technology1Manager.GetList();
            var technology2 = await technology2Manager.GetList();
            var technology3 = await technology3Manager.GetList();

            var model = new HeaderModel
            {
                Links = link,
                Technology1 = technology1,
                Technology2 = technology2,
                Technology3 = technology3,
            };

            return View(model);
        }
    }
}
