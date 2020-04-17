using BaxterCommerce.CommonClasses.Users;
using BaxterCommerceClientApp.Web.Services;
using BaxterCommerceClientApp.Web.Services.ApiError;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("/user/register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserResource userResource) =>
            await ExecuteControllerAction(async () => { return await _userService.RegisterNewUser(userResource); });

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost("/user/login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest) =>
            await ExecuteControllerAction(async () => { return await _userService.LoginUser(loginRequest); });
            

        private async Task<IActionResult> ExecuteControllerAction(Func<Task<object>> action)
        {
            try
            {
                return Ok(await action());
            }
            catch (Exception ex)
            {
                var error = new ApiError();
                error.Messages.Add(ex.Message);

                return BadRequest(error);
            }
        }
    }
}
