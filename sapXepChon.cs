using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan_SapXep
{
    public class sapXepChon
    {
        public static void SelectionSort(int[] a)
        {
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int k = i; //giả sử k là vị trí phần tử nhỏ nhất
                for (int j = i + 1; j < n; j++) //tìm phần tử nhỏ nhất trong mảng chưa sắp xếp
                {
                    if (a[j] < a[k])
                        k = j;
                }
                // Hoán đổi
                if (k != i) //nếu tìm thấy min mới thì hoán vị
                {
                    int temp = a[k];
                    a[k] = a[i];
                    a[i] = temp;
                }
            }
        }
    }
}
