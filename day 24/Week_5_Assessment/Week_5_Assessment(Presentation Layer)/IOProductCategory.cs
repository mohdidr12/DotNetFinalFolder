using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assessment
{
    class IOProductCategory
    {
        ConnectionClass cs = new ConnectionClass();
        public void InsertCategories()
        {
            Console.WriteLine("enter categoryId");
            int c_id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter categoryName");
            string c_name = Console.ReadLine();
            cs.AddCategory(c_id, c_name);

        }
        public void DisplayAllCategoriesUser()
        {
            cs.DisplayAllCategory();
        }
        public void InsertProducts()
        {
            Console.WriteLine("enter Productid");
            int p_id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Product name");
            string p_name = Console.ReadLine();
            Console.WriteLine("enter Product price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("enter categoryId of product");
            int cp_id = int.Parse(Console.ReadLine());
            cs.AddProduct(p_id, p_name, price, cp_id);
        }
        public void DisplayAllProductsUser()
        {
            cs.DisplayAllProducts();
        }
        public void SearchProductsUser()
        {
            Console.WriteLine("Enter Product Id Of a Product which you want to search");
            int up_id = int.Parse(Console.ReadLine());
            cs.SearchProduct(up_id);

        }
        public void UpdateProductPriceUser()
        {
            Console.WriteLine("Enter Product Id Of a Product ");
            int up_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Price");
            double up_price = double.Parse(Console.ReadLine());
            cs.UpdateProductPrice(up_price, up_id);

        }
        public void DeleteProductUser()
        {
            Console.WriteLine("Enter Product Id Of a Product in order to perform deletion ");
            int id = int.Parse(Console.ReadLine());
            cs.DeleteProduct(id);
        }
        public void DisplayProductCategories()
        {
            cs.DisplayProductWithCategories();
        }
    }
}
