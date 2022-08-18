using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assessment
{
    class ProductCategoryService : IProduct,ICategory
    {
        ConnectionClass cs = new ConnectionClass();
       public  void AddInsertProduct(int p_id, string p_name, double price, int cp_id)
        {
            if(cs.AddProduct(p_id,p_name,price,cp_id))
            {
                Console.WriteLine("Products Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Products Not Inserted");
            }
        }
       public void DisplayAllProduct()
        {
            if(cs.DisplayAllProducts())
            {
                Console.WriteLine("All Products Are shown Below");
            }
            else
            {
                Console.WriteLine("No Products are there to Display , Pleaase Add Some");
            }
        }
       public void SProduct(int p_id)
        {
            if(cs.SearchProduct(p_id))
            {
                Console.WriteLine("products are Search Successfully");
            }
            else
            {
                Console.WriteLine("products not  Search Successfully");
            }
        }
        public void UpdateProductPrice(double price, int p_id)
        {
            if (cs.UpdateProductPrice(price, p_id))
            {
                Console.WriteLine("products price Update Succcessfully");
            }
            else
            {

                Console.WriteLine("products price not Updated Succcessfully");

            }
        }
      public   void DeleteProduct(int p_id)
        {
            if(cs.DeleteProduct(p_id))
            {
                Console.WriteLine("products deleted Succcessfully");
            }
            else
            {
                Console.WriteLine("products  not deleted Succcessfully");
            }
        }
        public void AddCategory(int c_id, string c_name)
        {
            if(cs.AddCategory(c_id,c_name))
             {
                Console.WriteLine("Category Added Successfully");
             }
            else
            {
                Console.WriteLine("Category not Added Successfully");
            }
        }
        public void DisplayAllCategory()
        {
            if(cs.DisplayAllCategory())
            {
                Console.WriteLine("All Category are shown below");
            }
            else
            {
                Console.WriteLine("No data in categories , please Add some");
            }
        }
    }
}
