using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean flag = true;
            IOProductCategory pc = new IOProductCategory();
            while (flag)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. To Add a Product");
                Console.WriteLine("2. To Display All  Products");
                Console.WriteLine("3. To Search a  Product based on ProductId");
                Console.WriteLine("4. To Update a Price of Product");
                Console.WriteLine("5. To Delete a product");
                Console.WriteLine("**********************************");
                Console.WriteLine("6. To Add a Category");
                Console.WriteLine("7. To display All category");
                Console.WriteLine("**********************************");
                Console.WriteLine("8. To display All Products with particular categories");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        pc.InsertProducts();
                        break;
                    case 2:
                        pc.DisplayAllProductsUser();
                        break;
                    case 3:
                        pc.SearchProductsUser();
                        break;
                    case 4:
                        pc.UpdateProductPriceUser();
                        break;
                    case 5:
                        pc.DeleteProductUser();
                        break;
                    case 6:
                        pc.InsertCategories();
                        break;
                    case 7:
                        pc.DisplayAllCategoriesUser();
                        break;
                    case 8:
                        pc.DisplayProductCategories();
                        break;

                    default:
                        Console.WriteLine("No Valid Option from the Above Selection ");
                        flag = false;
                        break;

                }
            }
        }
    }
}
