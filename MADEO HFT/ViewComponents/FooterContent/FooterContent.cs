using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MADEO_HFT.ViewComponents.FooterContent
{
    public class FooterContent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        FooterManager footerManager = new FooterManager(new EFFooterRepository());

        public async Task<Microsoft.AspNetCore.Mvc.IViewComponentResult> InvokeAsync()
        {
            var footer = await footerManager.GetList();

            return View(footer);
        }
    }
}
