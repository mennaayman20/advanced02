using System;
using System.Collections.Generic;
using System.Text;

namespace advanced02
{
    public class ReportService
    {
        public static void PrintReport(List<Product> products, Action<Product> printAction)
        {
            foreach (var product in products)
            {
                printAction(product); // تنفيذ طريقة الطباعة التي يحددها المستخدم
            }
        }

        public static List<TResult> TransformProducts<TResult>(List<Product> products, Func<Product, TResult> transformer)
        {
            List<TResult> results = new();
            foreach (var product in products)
            {
                results.Add(transformer(product)); // تطبيق دالة التحويل الممررة على كل منتج
            }
            return results;
        }


        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
        {
            List<Product> filteredList = new();
            foreach (var product in products)
            {
                if (predicate(product)) // التحقق مما إذا كان المنتج يحقق الشرط
                {
                    filteredList.Add(product);
                }
            }
            return filteredList;
        }


    }
}
