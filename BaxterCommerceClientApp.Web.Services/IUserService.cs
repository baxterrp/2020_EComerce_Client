using BaxterCommerce.CommonClasses.Users;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services
{
    /// <summary>
    /// Services for handling <see cref="UserResource"/>
    /// </summary>
    public interface IUserService
    { 
        /// <summary>
        /// Registers a new <see cref="UserResource"/>
        /// </summary>
        /// <param name="userResource"><see cref="UserResource"/></param>
        /// <returns>The registered <see cref="UserResource"/></returns>
        Task<UserResource> RegisterNewUser(UserResource userResource);

        /// <summary>
        /// Attempts to login using <see cref="LoginRequest"/>
        /// </summary>
        /// <param name="loginRequest"><see cref="LoginRequest"/></param>
        /// <returns><see cref="LoginResponse"/></returns>
        Task<LoginResponse> LoginUser(LoginRequest loginRequest);
    }
}
