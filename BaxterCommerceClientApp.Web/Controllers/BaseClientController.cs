using BaxterCommerce.CommonClasses;
using BaxterCommerceClientApp.Web.Services.ApiError;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Controllers
{
    public class BaseClientController : Controller
    {
        protected async Task<IActionResult> ExecuteControllerAction(Func<Task<object>> action)
        {
            try
            {
                return Ok(await action());
            }
            catch (ApiException ex)
            {
                var error = new ApiError();
                error.Messages.Add(ex.Message);

                return BadRequest(error);
            }
        }
    }
}