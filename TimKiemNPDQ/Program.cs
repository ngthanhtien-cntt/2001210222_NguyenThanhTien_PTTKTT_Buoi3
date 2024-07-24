using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNPDQ
{
    class Program
    {
        // Hàm tìm kiếm nhị phân đệ qui
        static int TimKiemNPDQ(int[] arr, int low, int high, int target)
        {
            if (low > high)
                return -1; // Không tìm thấy phần tử

            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid; // Đã tìm thấy phần tử

            if (arr[mid] < target)
                return TimKiemNPDQ(arr, mid + 1, high, target); // Tìm trong nửa phải
            else
                return TimKiemNPDQ(arr, low, mid - 1, target); // Tìm trong nửa trái
        }

        static void Main()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }; // Mảng đã được sắp xếp

            Console.Write("Nhap gia tri can tim: ");
            int target = int.Parse(Console.ReadLine());

            int result = TimKiemNPDQ(arr, 0, arr.Length - 1, target);

            if (result != -1)
                Console.WriteLine("Gia tri {0} duoc tim thay tai {1}.", target, result);
            else
                Console.WriteLine("Gia tri {0} khong duoc tim thay trong mang.", target);
            Console.ReadLine();
        }
    }
}
