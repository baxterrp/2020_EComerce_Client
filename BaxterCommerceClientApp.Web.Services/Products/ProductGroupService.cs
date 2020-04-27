using BaxterCommerce.CommonClasses.Products;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services.Products
{
    /// <summary>
    /// Implements <see cref="IProductGroupService"/>
    /// </summary>
    public class ProductGroupService : IProductGroupService
    {
        /// <summary>
        /// Implements <see cref="IProductGroupService.CreateProductGroup(ProductGroup)"/>
        /// </summary>
        public Task<ProductGroup> CreateProductGroup(ProductGroup productGroup) =>
            Task.FromResult(new ProductGroup { Name = "Test" });

        /// <summary>
        /// Implements <see cref="IProductGroupService.GetAllProductGroups"/>
        /// </summary>
        public Task<IEnumerable<ProductGroup>> GetAllProductGroups() =>
            Task.FromResult(Enumerable.Empty<ProductGroup>());
    }
}
