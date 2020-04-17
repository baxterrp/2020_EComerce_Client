using BaxterCommerce.CommonClasses.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("/user/register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserResource userResource)
        {
            return NoContent();
        }
    }
}
