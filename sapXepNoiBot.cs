using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan_SapXep
{
    public class sapXepNoiBot
    {
        public static void BubbleSort(int[] a)
        {
            int n = a.Length;
            // Duyệt qua từng phần tử để đưa phần tử nhỏ nhất về vị trí i
            for (int i = 0; i < n - 1; i++)
            {
                // Vòng lặp trong: Duyệt ngược từ cuối mảng về vị trí i
                // Mục đích: "Nổi" phần tử nhỏ nhất lên vị trí i
                for (int j = n - 1; j > i; j--)
                {
                    // Nếu phần tử đứng sau nhỏ hơn phần tử đứng trước → Hoán đổi
                    if (a[j] < a[j - 1])
                    {
                        int temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
                }
            }
        }
    }
}
