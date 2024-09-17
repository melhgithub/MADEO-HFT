using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class AdminFooter : Controller
    {
        FooterManager footerManager = new FooterManager(new EFFooterRepository());

        public async Task<IActionResult> Index()
        {
            var footer = await footerManager.GetList();
            var filter = new FooterEditDto();

            var model = new FooterEditViewModel
            {
                Footer = footer,
                FilterDto = filter
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(FooterEditDto footer)
        {
            try
            {
                var updatedFooter = await footerManager.GetByID(footer.ID);
                if (updatedFooter != null)
                {
                    updatedFooter.Title = footer.Title;
                    updatedFooter.Content = footer.Content;

                    await footerManager.Update(updatedFooter);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                var filter = new FooterEditDto();
                return View("Index", new FooterEditViewModel
                {
                    FilterDto = filter,
                    Footer = await footerManager.GetList(),
                });
            }
        }
    }
}
