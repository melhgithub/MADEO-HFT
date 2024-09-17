﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class AdminImages : Controller
    {
        ImageManager imageManager = new ImageManager(new EFImageRepository());
        private readonly IWebHostEnvironment _env;
        public AdminImages(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            RefreshImageList();
            return View(Images);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(List<IFormFile> images)
        {
            if (images != null && images.Count > 0)
            {
                foreach (var image in images)
                {
                    if (image.Length > 0)
                    {
                        var imagePath = Path.Combine(_env.WebRootPath, "Resimler", image.FileName);
                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            image.CopyTo(stream);
                        }

                        await kaydet(image.FileName);
                    }
                }
            }

            RefreshImageList();

            return RedirectToAction(nameof(Index));
        }

        private async Task kaydet(string fileName)
        {
            Image image = new Image
            {
                Name = fileName
            };
            await imageManager.Add(image);
        }

        private async Task sil(string fileName)
        {
            var image = await imageManager.GetImageByName(fileName);
            await imageManager.Delete(image);
        }
        public IActionResult Delete(string image)
        {
            if (!string.IsNullOrEmpty(image))
            {
                var imagePath = Path.Combine(_env.WebRootPath, "Resimler", image);
                if (System.IO.File.Exists(imagePath))
                {
                    _ = sil(image);
                    System.IO.File.Delete(imagePath);
                }
            }

            RefreshImageList();

            return RedirectToAction(nameof(Index));
        }

        private List<string> Images = new List<string>();
        private void RefreshImageList()
        {
            var imageDirectory = Path.Combine(_env.WebRootPath, "Resimler");
            Images = Directory.GetFiles(imageDirectory)
                .Select(filePath => Path.GetFileName(filePath))
                .ToList();
        }
    }
}
