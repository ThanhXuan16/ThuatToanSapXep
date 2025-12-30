using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan_SapXep
{
    public class sapXepChen
    {
        public static void InsertionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; ++i)
            {
                int x = a[i]; //lưu giá trị cần chèn
                int j = i - 1;

                // Di chuyển các phần tử của a[0..i-1], những phần tử lớn hơn x sang phải
                while (j >= 0 && a[j] > x)
                {
                    a[j + 1] = a[j]; 
                    j = j - 1;
                }
                // Chèn x vào vị trí thích hợp
                a[j + 1] = x;
            }
        }
    }
}
