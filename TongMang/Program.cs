using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongMang
{
    class Program
    {
        static int TongMang(int[] arr)
        {
            int Tong = 0;
            int length = arr.Length;
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            stack.Push(Tuple.Create(0, length - 1));// Đưa đoạn từ 0 đến length-1 vào stack
            while (stack.Count > 0)
            {
                var range = stack.Pop();
                int left = range.Item1;
                int right = range.Item2;

                if(left == right)
                {
                    Tong += arr[left];// Cộng phần tử vào tổng
                }
                else
                {
                    int mid = (left + right) / 2;
                    stack.Push(Tuple.Create(left, mid));
                    stack.Push(Tuple.Create(mid + 1, right));
                }
            }
            return Tong;
        }
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            for(int i = 0; i<n; i++)
            {
                arr[i] = i + 1;
            }
            Console.WriteLine(TongMang(arr));
            Console.ReadLine();
        }
    }
}
