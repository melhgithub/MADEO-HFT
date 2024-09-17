using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class AdminTechnology : Controller
    {
        Technology1Manager technology1Manager = new Technology1Manager(new EFTechnology1Repository());
        Technology2Manager technology2Manager = new Technology2Manager(new EFTechnology2Repository());
        Technology3Manager technology3Manager = new Technology3Manager(new EFTechnology3Repository());
        ProductManager productManager = new ProductManager(new EFProductRepository());
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        public async Task<IActionResult> Index()
        {
            var products = await productManager.GetList();
            var technology1 = await technology1Manager.GetList();
            var technology2 = await technology2Manager.GetList();
            var technology3 = await technology3Manager.GetList();
            var image = await imageManager.GetList();

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
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Update(TechnologyEditDto technologydatas)
        {
            try
            {
                var updatedTech1 = await technology1Manager.GetByID(technologydatas.T1ID);

                var updatedTech2 = await technology2Manager.GetByID(technologydatas.T2ID);

                var updatedTech3 = await technology3Manager.GetByID(technologydatas.T3ID);


                if (updatedTech1 != null)
                {
                    updatedTech1.MainTitle = technologydatas.T1MainTitle;
                    updatedTech1.Title = technologydatas.T1Title;
                    updatedTech1.Text1 = technologydatas.T1Text1;
                    updatedTech1.Text2 = technologydatas.T1Text2;
                    updatedTech1.Text3 = technologydatas.T1Text3;
                    updatedTech1.Text4 = technologydatas.T1Text4;

                    if (technologydatas.T1Image1 == "null")
                    {
                        updatedTech1.Image1 = null;
                    }
                    if (technologydatas.T1Image1 != null && technologydatas.T1Image1 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T1Image1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech1.Image1)
                        {
                            updatedTech1.Image1 = image.Name;
                        }
                    }

                    if (technologydatas.T1Image2 == "null")
                    {
                        updatedTech1.Image2 = null;
                    }
                    if (technologydatas.T1Image2 != null && technologydatas.T1Image2 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T1Image2);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech1.Image2)
                        {
                            updatedTech1.Image2 = image.Name;
                        }
                    }

                    if (technologydatas.T1Banner1 == "null")
                    {
                        updatedTech1.Banner1 = null;
                    }
                    if (technologydatas.T1Banner1 != null && technologydatas.T1Banner1 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T1Banner1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech1.Banner1)
                        {
                            updatedTech1.Banner1 = image.Name;
                        }
                    }

                    if (technologydatas.T1Banner2 == "null")
                    {
                        updatedTech1.Banner2 = null;
                    }
                    if (technologydatas.T1Banner2 != null && technologydatas.T1Banner2 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T1Banner2);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech1.Banner2)
                        {
                            updatedTech1.Banner2 = image.Name;
                        }
                    }

                    if (technologydatas.T1Banner3 == "null")
                    {
                        updatedTech1.Banner3 = null;
                    }
                    if (technologydatas.T1Banner3 != null && technologydatas.T1Banner3 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T1Banner3);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech1.Banner3)
                        {
                            updatedTech1.Banner3 = image.Name;
                        }
                    }

                }

                await technology1Manager.Update(updatedTech1);

                if (updatedTech2 != null)
                {
                    updatedTech2.MainTitle = technologydatas.T2MainTitle;
                    updatedTech2.Title = technologydatas.T2Title;
                    updatedTech2.Text1 = technologydatas.T2Text1;
                    updatedTech2.Text2 = technologydatas.T2Text2;
                    updatedTech2.Text3 = technologydatas.T2Text3;
                    updatedTech2.Text4 = technologydatas.T2Text4;

                    if (technologydatas.T2Image1 == "null")
                    {
                        updatedTech2.Image1 = null;
                    }
                    if (technologydatas.T2Image1 != null && technologydatas.T2Image1 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T2Image1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech2.Image1)
                        {
                            updatedTech2.Image1 = image.Name;
                        }
                    }

                    if (technologydatas.T2Image2 == "null")
                    {
                        updatedTech2.Image2 = null;
                    }
                    if (technologydatas.T2Image2 != null && technologydatas.T2Image2 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T2Image2);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech2.Image2)
                        {
                            updatedTech2.Image2 = image.Name;
                        }
                    }

                    if (technologydatas.T2Banner1 == "null")
                    {
                        updatedTech2.Banner1 = null;
                    }
                    if (technologydatas.T2Banner1 != null && technologydatas.T2Banner1 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T2Banner1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech2.Banner1)
                        {
                            updatedTech2.Banner1 = image.Name;
                        }
                    }

                    if (technologydatas.T2Banner2 == "null")
                    {
                        updatedTech2.Banner2 = null;
                    }
                    if (technologydatas.T2Banner2 != null && technologydatas.T2Banner2 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T2Banner2);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech2.Banner2)
                        {
                            updatedTech2.Banner2 = image.Name;
                        }
                    }

                    if (technologydatas.T2Banner3 == "null")
                    {
                        updatedTech2.Banner3 = null;
                    }
                    if (technologydatas.T2Banner3 != null && technologydatas.T2Banner3 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T2Banner3);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech2.Banner3)
                        {
                            updatedTech2.Banner3 = image.Name;
                        }
                    }

                }

                await technology2Manager.Update(updatedTech2);

                if (updatedTech3 != null)
                {
                    updatedTech3.MainTitle = technologydatas.T3MainTitle;
                    updatedTech3.Title = technologydatas.T3Title;
                    updatedTech3.Text1 = technologydatas.T3Text1;
                    updatedTech3.Text2 = technologydatas.T3Text2;
                    updatedTech3.Text3 = technologydatas.T3Text3;
                    updatedTech3.Text4 = technologydatas.T3Text4;

                    if (technologydatas.T3Image1 == "null")
                    {
                        updatedTech3.Image1 = null;
                    }
                    if (technologydatas.T3Image1 != null && technologydatas.T3Image1 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T3Image1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech3.Image1)
                        {
                            updatedTech3.Image1 = image.Name;
                        }
                    }

                    if (technologydatas.T3Image2 == "null")
                    {
                        updatedTech3.Image2 = null;
                    }
                    if (technologydatas.T3Image2 != null && technologydatas.T3Image2 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T3Image2);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech3.Image2)
                        {
                            updatedTech3.Image2 = image.Name;
                        }
                    }

                    if (technologydatas.T3Banner1 == "null")
                    {
                        updatedTech3.Banner1 = null;
                    }
                    if (technologydatas.T3Banner1 != null && technologydatas.T3Banner1 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T3Banner1);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech3.Banner1)
                        {
                            updatedTech3.Banner1 = image.Name;
                        }
                    }

                    if (technologydatas.T3Banner2 == "null")
                    {
                        updatedTech3.Banner2 = null;
                    }
                    if (technologydatas.T3Banner2 != null && technologydatas.T3Banner2 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T3Banner2);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech3.Banner2)
                        {
                            updatedTech3.Banner2 = image.Name;
                        }
                    }

                    if (technologydatas.T3Banner3 == "null")
                    {
                        updatedTech3.Banner3 = null;
                    }
                    if (technologydatas.T3Banner3 != null && technologydatas.T3Banner3 != "null")
                    {
                        int imageid = int.Parse(technologydatas.T3Banner3);
                        var image = await imageManager.GetByID(imageid);
                        if (image.Name != updatedTech3.Banner3)
                        {
                            updatedTech3.Banner3 = image.Name;
                        }
                    }

                }

                await technology3Manager.Update(updatedTech3);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                var filter = new TechnologyEditDto();

                return View("Index", new TechnologyViewModel
                {
                    Products = await productManager.GetList(),
                    Technology1 = await technology1Manager.GetList(),
                    Technology2 = await technology2Manager.GetList(),
                    Technology3 = await technology3Manager.GetList(),
                    Images = await imageManager.GetList(),
                    FilterDto = filter
                });
            }
        }
    }
}
