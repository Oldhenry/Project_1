using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace ReverseTest
{
	class Program
	{
		// Reverses order of the bits in each byte in the array 
		private static void Reverse(byte[] values)
		{
            var arr = values.Reverse().ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                values[i] = arr[i];
            }
		}

		static void Main(string[] args)
		{
            byte[] bt = new byte[] { 4, 7, 2, 9, 1, 3, 9, 0, 4, 2 };
            Reverse(bt);
		}
	}
}
