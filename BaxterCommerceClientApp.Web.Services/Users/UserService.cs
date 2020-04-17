using BaxterCommerce.Client;
using BaxterCommerce.CommonClasses.Users;
using System;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services.Users
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IAuthenticationClient _authenticationClient;
        private readonly IUserRegistrationClient _userRegistrationClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="authenticationClient"></param>
        /// <param name="userRegistrationClient"></param>
        public UserService(IAuthenticationClient authenticationClient, IUserRegistrationClient userRegistrationClient)
        {
            _authenticationClient = authenticationClient ?? throw new ArgumentNullException(nameof(authenticationClient));
            _userRegistrationClient = userRegistrationClient ?? throw new ArgumentNullException(nameof(userRegistrationClient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        public async Task<LoginResponse> LoginUser(LoginRequest loginRequest)
        {
            var response = await _authenticationClient.Login(loginRequest);

            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userResource"></param>
        /// <returns></returns>
        public async Task<UserResource> RegisterNewUser(UserResource userResource)
        {
            var user = await _userRegistrationClient.RegisterNewUser(userResource);

            return user;
        }
    }
}
