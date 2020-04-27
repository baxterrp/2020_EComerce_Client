using BaxterCommerce.CommonClasses.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProductGroupService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productGroup"></param>
        /// <returns></returns>
        Task<ProductGroup> CreateProductGroup(ProductGroup productGroup);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductGroup>> GetAllProductGroups();
    }
}
