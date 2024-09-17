using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    [Authorize(Policy = "realadmin")]
    public class AdminController : Controller
    {
        AdminManager adminManager = new AdminManager(new EFAdminRepository());
        public async Task<IActionResult> Index()
        {
            var admins = await adminManager.GetList();
            var filterDto = new AdminEditDto();
            var model = new AdminControlViewModel
            {
                Admins = admins,
                FilterDto = filterDto
            };
            return View(model);
        }

        public async Task<IActionResult> Filter()
        {
            var admins = await adminManager.GetList();
            var adminData = admins.Select(p => new
            {
                ID = p.ID,
                Username = p.UserName,
                Password = p.Password,
            });

            return Json(adminData);
        }

        [HttpPost]
        public async Task<IActionResult> AddEditAdmin(AdminAddDto admin)
        {
            var response = new { success = false, message = "" };
            if (admin != null)
            {
                try
                {
                    var adminToUpdate = await adminManager.GetByID(admin.ID);
                    bool isUpdate = adminToUpdate != null;

                    Admin adminEntity;

                    if (isUpdate)
                    {
                        adminEntity = adminToUpdate;
                    }
                    else
                    {
                        adminEntity = new Admin();
                    }
                    if (!isUpdate || adminEntity.Password == admin.OldPassword)
                    {
                        if (admin.NewPassword == admin.ConfirmNewPassword)
                        {
                            if (admin.NewPassword != admin.OldPassword)
                            {
                                adminEntity.UserName = admin.UserName;
                                adminEntity.Password = admin.NewPassword;
                                if (isUpdate)
                                {
                                    await adminManager.Update(adminEntity);
                                    response = new { success = true, message = "Admin başarıyla güncellendi!" };
                                }
                                else
                                {
                                    await adminManager.Add(adminEntity);
                                    response = new { success = true, message = "Admin başarıyla eklendi!" };
                                }
                            }
                            else
                            {
                                response = new { success = false, message = "Şifreler uyuşmuyor!" };
                            }
                        }
                    }

                    else if (isUpdate || admin.NewPassword == admin.ConfirmNewPassword)
                    {
                        adminEntity.UserName = admin.UserName;
                        adminEntity.Password = admin.NewPassword;
                        if (isUpdate)
                        {
                            await adminManager.Update(adminEntity);
                            response = new { success = true, message = "Admin başarıyla güncellendi!" };
                        }
                        else
                        {
                            await adminManager.Add(adminEntity);
                            response = new { success = true, message = "Admin başarıyla eklendi!" };
                        }
                    }
                    else
                    {
                        response = new { success = false, message = "Şifre hatalı." };
                    }
                }
                catch (Exception)
                {

                    response = new { success = false, message = "Hata." };
                }
            }
            else
            {
                response = new { success = false, message = "Hata." };
            }

            return Json(response);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAdmin(AdminRemoveDto admin)
        {
            var response = new { success = false, message = "" };

            if (admin != null)
            {
                try
                {
                    var adminToRemove = await adminManager.GetByID(admin.ID);
                    if (adminToRemove != null)
                    {
                        await adminManager.Delete(adminToRemove);

                        response = new { success = true, message = "Başarılı." };
                    }
                    else
                    {
                        response = new { success = false, message = "Başarısız." };
                    }
                }
                catch (Exception)
                {
                    response = new { success = false, message = "Başarısız." };
                }
            }
            else
            {
                response = new { success = false, message = "Başarısız." };
            }
            return Json(response);
        }
    }
}
