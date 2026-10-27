using System;
using System.Collections.Generic;
using System.Text;

namespace advanced02
{
    public class SearchProducts
    {
        // 1. تعريف الدالة العامة للبحث
        public static List<Product> SearchProduct(List<Product> products, Func<Product, bool> filterCriteria)
        {
            List<Product> result = new();
            foreach (var product in products)
            {
                if (filterCriteria(product)) // تطبيق الشرط الممرر
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}
