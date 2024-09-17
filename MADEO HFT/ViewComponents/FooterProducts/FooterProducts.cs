using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MADEO_HFT.Models;

namespace MADEO_HFT.ViewComponents.FooterProducts
{
    public class FooterProducts : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        ProductManager productManager = new ProductManager(new EFProductRepository());
        FooterManager footerManager = new FooterManager(new EFFooterRepository());

        public async Task<Microsoft.AspNetCore.Mvc.IViewComponentResult> InvokeAsync()
        {
            var products = await productManager.GetList();
            var footer = await footerManager.GetList();

            var model = new FooterProductsViewModel
            {
                Products = products,
                Footer = footer
            };

            return View(model);
        }
    }
}
