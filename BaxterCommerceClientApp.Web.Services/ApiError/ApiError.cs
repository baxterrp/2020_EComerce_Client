using System;
using System.Collections.Generic;

namespace BaxterCommerceClientApp.Web.Services.ApiError
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// 
        /// </summary>
        public ApiError()
        {
            Messages = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> Messages { get; set; }
    }
}
