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
    }
}
