using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assessment
{

    interface IProduct
    {
        void AddInsertProduct(int p_id, string p_name, double price, int cp_id);
        void DisplayAllProduct();
        void SProduct(int p_id);
        void UpdateProductPrice(double price, int p_id);
        void DeleteProduct(int p_id);

    }
}
