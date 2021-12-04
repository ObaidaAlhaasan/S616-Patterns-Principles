using System.Collections.Generic;
using System.Security.Cryptography;
using Design_Patterns_OOP.Creational.Factory.Matcha;

namespace Design_Patterns_OOP.Creational.Factory
{
    public class ProductsController : BaseController
    {
        // /products/list
        public void ViewListProductsPage()
        {
            var context = new Dictionary<string, object>();
            Render("products-list.html", context);
        }

        protected override IViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}