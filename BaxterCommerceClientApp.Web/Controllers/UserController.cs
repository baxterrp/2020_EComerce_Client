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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost("/user/login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest) 
        {
            return NoContent();
        }
    }
}
