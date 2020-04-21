using System.Collections.Generic;

namespace BaxterCommerceClientApp.Web.Services.ApiError
{
    /// <summary>
    /// Contains any errors from API requests sent through client
    /// </summary>
    public class ApiError
    {
        public ApiError()
        {
            Messages = new List<string>();
        }

        /// <summary>
        /// Messages regarding related <see cref="System.Exception"/>
        /// </summary>
        public IList<string> Messages { get; set; }
    }
}
