using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MADEO_HFT.Controllers
{
    public class AdminForm : Controller
    {
        FormManager formManager = new FormManager(new EFFormRepository());
        public async Task<IActionResult> Index()
        {
            var requests = await formManager.GetList();
            var filterDto = new RequestEditDto();
            var model = new RequestViewModel
            {
                Requests = requests,
                FilterDto = filterDto
            };
            return View(model);
        }

        public async Task<IActionResult> Filter()
        {
            var requests = await formManager.GetList();
            var requestsData = requests.Select(p => new
            {
                ID = p.ID,
                Name= p.Name,
                Mail=p.Mail,
                Content=p.Message
            });

            return Json(requestsData);
        }

        [HttpPost]
        public async Task<IActionResult> AddEditRequest(RequestAddDto request)
        {
            var response = new { success = false, message = "" };
            if (request != null)
            {
                try
                {
                    var requestToUpdate = await formManager.GetByID(request.ID);
                    bool isUpdate = requestToUpdate != null;

                    Form requestEntity;

                    if (isUpdate)
                    {
                        requestEntity = requestToUpdate;
                    }
                    else
                    {
                        requestEntity = new Form();
                        requestEntity.Message = request.Message;
                        requestEntity.Name = request.Name;
                        requestEntity.Mail = request.Mail;
                    }
                    if (isUpdate)
                    {
                        await formManager.Update(requestEntity);
                        response = new { success = true, message = "Sent!" };
                    }
                    else
                    {
                        await formManager.Add(requestEntity);
                        response = new { success = true, message = "Sent!" };
                    }

                }
                catch (Exception)
                {

                    response = new { success = false, message = "Error." };
                }
            }
            else
            {
                response = new { success = false, message = "Error." };
            }

            return Json(response);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveRequest(RequestRemoveDto request)
        {
            var response = new { success = false, message = "" };

            if (request != null)
            {
                try
                {
                    var requestToRemove = await formManager.GetByID(request.ID);
                    if (requestToRemove != null)
                    {
                        await formManager.Delete(requestToRemove);

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
