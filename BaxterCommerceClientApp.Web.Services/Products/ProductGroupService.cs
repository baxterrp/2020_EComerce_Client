using BaxterCommerce.Client;
using BaxterCommerce.CommonClasses.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Services.Products
{
    /// <summary>
    /// Implements <see cref="IProductGroupService"/>
    /// </summary>
    public class ProductGroupService : IProductGroupService
    {
        private readonly IFindProductGroupClient _findProductGroupClient;
        private readonly ICreateProductGroupClient _createProductGroupClient;

        public ProductGroupService(IFindProductGroupClient findProductGroupClient, ICreateProductGroupClient createProductGroupClient)
        {
            _findProductGroupClient = findProductGroupClient ?? throw new ArgumentNullException(nameof(findProductGroupClient));
            _createProductGroupClient = createProductGroupClient ?? throw new ArgumentNullException(nameof(createProductGroupClient));
        }

        /// <summary>
        /// Implements <see cref="IProductGroupService.CreateProductGroup(ProductGroup)"/>
        /// </summary>
        public async Task<ProductGroup> CreateProductGroup(ProductGroup productGroup) =>
            await _createProductGroupClient.AddProductGroup(productGroup);

        /// <summary>
        /// Implements <see cref="IProductGroupService.GetAllProductGroups"/>
        /// </summary>
        public async Task<IEnumerable<ProductGroup>> GetAllProductGroups() =>
            await _findProductGroupClient.GetAllProductGroups();
    }
}
