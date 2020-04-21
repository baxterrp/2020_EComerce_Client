using BaxterCommerce.Client;
using BaxterCommerce.CommonClasses.Users;
using System;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services.Users
{
    /// <summary>
    /// Services for handling <see cref="UserResource"/>
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IAuthenticationClient _authenticationClient;
        private readonly IUserRegistrationClient _userRegistrationClient;

        public UserService(IAuthenticationClient authenticationClient, IUserRegistrationClient userRegistrationClient)
        {
            _authenticationClient = authenticationClient ?? throw new ArgumentNullException(nameof(authenticationClient));
            _userRegistrationClient = userRegistrationClient ?? throw new ArgumentNullException(nameof(userRegistrationClient));
        }

        /// <summary>
        /// Implements <see cref="IUserService.LoginUser(LoginRequest)"/>
        /// </summary>
        public async Task<LoginResponse> LoginUser(LoginRequest loginRequest)
        {
            var response = await _authenticationClient.Login(loginRequest);

            return response;
        }

        /// <summary>
        /// Implements <see cref="IUserService.RegisterNewUser(UserResource)"/>
        /// </summary>
        public async Task<UserResource> RegisterNewUser(UserResource userResource)
        {
            var user = await _userRegistrationClient.RegisterNewUser(userResource);

            return user;
        }
    }
}
