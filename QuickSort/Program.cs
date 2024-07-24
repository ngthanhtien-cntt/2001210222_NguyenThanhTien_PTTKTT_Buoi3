using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Chọn phần tử cuối làm chốt
            int i = (low - 1); // Chỉ số của phần tử nhỏ hơn
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return i + 1;
        }
        // Hàm QuickSort đệ qui
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Pi là chỉ số nơi chốt được đặt đúng vị trí
                int pi = Partition(arr, low, high);

                // Sắp xếp các phần tử trước và sau phần chốt
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 34, 7, 23, 32, 5, 62 }; // Mảng gồm 6 phần tử

            Console.WriteLine("Mang ban dau:");
            Console.WriteLine(string.Join(", ", arr));

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Mang sau khi sap xep:");
            Console.WriteLine(string.Join(", ", arr));
            Console.ReadLine();
        }
    }
}
