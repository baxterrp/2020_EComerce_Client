using BaxterCommerce.CommonClasses.Products;
using BaxterCommerceClientApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaxterCommerceClientApp.Web.Controllers
{
    /// <summary>
    /// Controller for handling <see cref="ProductGroup"/>
    /// </summary>
    public class ProductGroupController : BaseClientController
    {
        private readonly IProductGroupService _productGroupService;

        public ProductGroupController(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService ?? throw new ArgumentNullException(nameof(productGroupService));
        }

        /// <summary>
        /// Adds new <see cref="ProductGroup"/>
        /// </summary>
        /// <param name="productGroup"><see cref="ProductGroup"/></param>
        /// <returns>The added <see cref="ProductGroup"/></returns>
        [HttpPost("/groups")]
        public async Task<IActionResult> AddNewGroup([FromBody] ProductGroup productGroup) => 
            await ExecuteControllerAction(async () => await _productGroupService.CreateProductGroup(productGroup));

        /// <summary>
        /// Finds all <see cref="ProductGroup"/>
        /// </summary>
        /// <returns><see cref="IEnumerable{T}"/> of <see cref="ProductGroup"/></returns>
        [HttpGet("/groups")]
        public async Task<IActionResult> GetAllGroups() =>
             await ExecuteControllerAction(async () => await _productGroupService.GetAllProductGroups());
    }
}