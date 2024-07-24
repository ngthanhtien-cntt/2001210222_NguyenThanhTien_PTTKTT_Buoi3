using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNPKDQ
{
    class Program
    {
        // Hàm tìm kiếm nhị phân không đệ qui
        static int TimKiemNP(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return mid; // Đã tìm thấy phần tử

                if (arr[mid] < target)
                    low = mid + 1; // Tìm trong nửa phải
                else
                    high = mid - 1; // Tìm trong nửa trái
            }

            return -1; // Không tìm thấy phần tử
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }; // Mảng đã được sắp xếp

            Console.Write("Nhap gia tri can tim: ");
            int target = int.Parse(Console.ReadLine());

            int result = TimKiemNP(arr, target);

            if (result != -1)
                Console.WriteLine("Gia tri {0} duoc tim thay tai {1}.", target, result);
            else
                Console.WriteLine("Gia tri {0} khong duoc tim thay trong mang.", target);
            Console.ReadLine();
        }
    }
}
