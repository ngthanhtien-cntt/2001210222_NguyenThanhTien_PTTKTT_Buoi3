using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongMangDQ
{
    class Program
    {
        static int TongMangDQ(int[] arr, int left, int right)
        {
            if (left == right) // Nếu đoạn chỉ có một phần tử
            {
                return arr[left]; // Trả về phần tử đó
            }
            else
            {
                int mid = (left + right) / 2; // Tính điểm giữa của đoạn
                // Đệ qui tính tổng của đoạn bên trái và bên phải
                return TongMangDQ(arr, left, mid) + TongMangDQ(arr, mid + 1, right);
            }
        }

        static void Main()
        {
            int n = 10; // Thay đổi giá trị n tại đây
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1; // Khởi tạo mảng từ 1 đến n
            }
            Console.WriteLine(TongMangDQ(arr, 0, arr.Length - 1)); 
            Console.ReadLine();
        }
    }
}
