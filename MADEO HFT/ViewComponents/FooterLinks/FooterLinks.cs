using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.Models;

namespace MADEO_HFT.ViewComponents.FooterLinks
{
    public class FooterLinks : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        FooterManager footerManager = new FooterManager(new EFFooterRepository());
        LinkManager linkManager = new LinkManager(new EFLinkRepository());

        public async Task<Microsoft.AspNetCore.Mvc.IViewComponentResult> InvokeAsync()
        {
            var footer = await footerManager.GetList();
            var link = await linkManager.GetList();

            var model = new FooterLinkModel
            {
                Footer = footer,
                Link = link
            };
            return View(model);
        }
    }
}
