using BaxterCommerce.CommonClasses.Users;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserService
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userResource"></param>
        /// <returns></returns>
        Task<UserResource> RegisterNewUser(UserResource userResource);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task<LoginResponse> LoginUser(LoginRequest loginRequest);
    }
}
