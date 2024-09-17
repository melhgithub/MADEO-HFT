using Azure;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class AdminProduct : Controller
    {
        ProductManager productManager = new ProductManager(new EFProductRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        public async Task<IActionResult> Index()
        {
            var products = await productManager.GetList();
            var images = await imageManager.GetList();

            var filter = new ProductFilterDto
            {
                Images = images
            };

            var model = new ProductsViewModel
            {
                Products = products,
                FilterDto = filter
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Filter()
        {
            var products = await productManager.GetList();

            var productData = products.Select(p => new
            {
                ID = p.ID,
                Title = p.Title,
                Text = p.Text,
                Image = p.Image,
                Slider1 = p.Slider1,
                Slider2 = p.Slider2,
                Slider3 = p.Slider3,
                Slider4 = p.Slider4,
                Slider5 = p.Slider5,
                Video1link = p.Video1Link,
                Video2link = p.Video2Link,
                Video3link = p.Video3Link,
                Video4link = p.Video4Link,
                Video5link = p.Video5Link,
                Video1title = p.Video1Title,
                Video2title = p.Video2Title,
                Video3title = p.Video3Title,
                Video4title = p.Video4Title,
                Video5title = p.Video5Title,
                Video1text = p.Video1Text,
                Video2text = p.Video2Text,
                Video3text = p.Video3Text,
                Video4text = p.Video4Text,
                Video5text = p.Video5Text,
                Video1 = p.Video1,
                Video2 = p.Video2,
                Video3 = p.Video3,
                Video4 = p.Video4,
                Video5 = p.Video5,
            });

            return Json(productData);
        }

        [HttpPost]
        public async Task<IActionResult> AddEditProduct(ProductAddEditDto product)
        {
            var response = new { success = false, message = "" };

            if (product != null)
            {
                try
                {
                    var entity = product.ID > 0 ? await productManager.GetByID(product.ID) : new Product();

                    entity.Title = product.Title;
                    entity.Text = product.Text;
                    entity.Video1Link = product.Video1Link;
                    entity.Video2Link = product.Video2Link;
                    entity.Video3Link = product.Video3Link;
                    entity.Video4Link = product.Video4Link;
                    entity.Video5Link = product.Video5Link;
                    entity.Video1Text = product.Video1Text;
                    entity.Video2Text = product.Video2Text;
                    entity.Video3Text = product.Video3Text;
                    entity.Video4Text = product.Video4Text;
                    entity.Video5Text = product.Video5Text;
                    entity.Video1Title = product.Video1Title;
                    entity.Video2Title = product.Video2Title;
                    entity.Video3Title = product.Video3Title;
                    entity.Video4Title = product.Video4Title;
                    entity.Video5Title = product.Video5Title;
                    if (product.Video1 == "1")
                    {
                        entity.Video1 = true;
                    }
                    else
                    {
                        entity.Video1 = false;
                    }
                    if (product.Video2 == "1")
                    {
                        entity.Video2 = true;
                    }
                    else
                    {
                        entity.Video2 = false;
                    }
                    if (product.Video3 == "1")
                    {
                        entity.Video3 = true;
                    }
                    else
                    {
                        entity.Video3 = false;
                    }
                    if (product.Video4 == "1")
                    {
                        entity.Video4 = true;
                    }
                    else
                    {
                        entity.Video4 = false;
                    }
                    if (product.Video5 == "1")
                    {
                        entity.Video5 = true;
                    }
                    else
                    {
                        entity.Video5 = false;
                    }

                    if (product.Image != null)
                    {
                        int.TryParse(product.Image, out int imageurl);
                        var image = await imageManager.GetByID(imageurl);
                        entity.Image = image.Name;
                    }
                    if (entity.ID > 0 && product.Image == null)
                    {
                        entity.Image = null;
                    }

                    if (product.Slider1 != null)
                    {
                        int.TryParse(product.Slider1, out int imageurl);
                        var image = await imageManager.GetByID(imageurl);
                        entity.Slider1 = image.Name;
                    }
                    if (entity.ID > 0 && product.Slider1 == null)
                    {
                        entity.Slider1 = null;
                    }

                    if (product.Slider2 != null)
                    {
                        int.TryParse(product.Slider2, out int imageurl);
                        var image = await imageManager.GetByID(imageurl);
                        entity.Slider2 = image.Name;
                    }
                    if (entity.ID > 0 && product.Slider2 == null)
                    {
                        entity.Slider2 = null;
                    }

                    if (product.Slider3 != null)
                    {
                        int.TryParse(product.Slider3, out int imageurl);
                        var image = await imageManager.GetByID(imageurl);
                        entity.Slider3 = image.Name;
                    }
                    if (entity.ID > 0 && product.Slider3 == null)
                    {
                        entity.Slider3 = null;
                    }

                    if (product.Slider4 != null)
                    {
                        int.TryParse(product.Slider4, out int imageurl);
                        var image = await imageManager.GetByID(imageurl);
                        entity.Slider4 = image.Name;
                    }
                    if (entity.ID > 0 && product.Slider4 == null)
                    {
                        entity.Slider4 = null;
                    }

                    if (product.Slider5 != null)
                    {
                        int.TryParse(product.Slider5, out int imageurl);
                        var image = await imageManager.GetByID(imageurl);
                        entity.Slider5 = image.Name;
                    }
                    if (entity.ID > 0 && product.Slider5 == null)
                    {
                        entity.Slider5 = null;
                    }

                    if (entity.ID > 0)
                    {
                        await productManager.Update(entity);
                        response = new { success = true, message = "Ürün başarıyla güncellendi!" };
                    }
                    else
                    {
                        await productManager.Add(entity);
                        response = new { success = true, message = "Ürün başarıyla eklendi!" };
                    }
                }
                catch (Exception)
                {
                    response = new { success = false, message = "Lütfen formu kontrol ediniz." };
                }
            }
            else
            {
                response = new { success = false, message = "Hata oluştu!" };
            }

            return Json(response);
        }


        [HttpPost]
        public async Task<IActionResult> RemoveProduct(ProductRemoveDto product)
        {
            var response = new { success = false, message = "" };

            if (product != null)
            {
                try
                {
                    var productToRemove = await productManager.GetByID(product.ID);

                    if (productToRemove != null)
                    {
                        await productManager.Delete(productToRemove);
                        response = new { success = true, message = "Ürün başarıyla silindi!" };
                    }
                    else
                    {
                        response = new { success = false, message = "Ürün Bulunamadı" };
                    }
                }
                catch (Exception)
                {
                    response = new { success = false, message = "Lütfen formu kontrol ediniz." };
                }
            }
            else
            {
                response = new { success = false, message = "Hata oluştu!" };
            }
            return Json(response);
        }
    }
}
