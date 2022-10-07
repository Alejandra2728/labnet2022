using Lab.MVC.Entities;
using Lab.MVC.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.UI.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        private readonly IABMLogic<Products> _iABMLogic;

        public ProductsController(IABMLogic<Products> iABMLogic)
        {
            _iABMLogic = iABMLogic;
        }

        public async Task<ActionResult<Products>> Update([FromBody]Products product, int id)
        {
            var productUpdate = await _iABMLogic.Update(product,id);
            return productUpdate;
        }
    }
}