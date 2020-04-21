using BaxterCommerce.CommonClasses.Users;
using BaxterCommerceClientApp.Web.Services;
using BaxterCommerceClientApp.Web.Services.ApiError;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Controllers
{
    /// <summary>
    /// Controller for handling <see cref="UserResource"/>
    /// </summary>
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        /// <summary>
        /// Registers a new <see cref="UserResource"/>
        /// </summary>
        /// <param name="userResource"><see cref="UserResource"/></param>
        /// <returns>The registered <see cref="UserResource"/></returns>
        [HttpPost("/user/register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserResource userResource) =>
            await ExecuteControllerAction(async () => { return await _userService.RegisterNewUser(userResource); });

        /// <summary>
        /// Logs in using a <see cref="LoginRequest"/>
        /// </summary>
        /// <param name="loginRequest"><see cref="LoginRequest"/></param>
        /// <returns><see cref="LoginResponse"/></returns>
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
