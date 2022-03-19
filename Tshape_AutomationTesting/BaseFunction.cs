using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tshape_AutomationTesting
{
    internal class BaseFunction
    {
		public static int GetMaximumNumber(int[] arr)
		{
			int result = 0;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] - arr[i] > result)
					{
						result = arr[j] - arr[i];
					}
				}
			}
			return result;
		}

		public static string CapitalizeTheFirstLetter(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			var words = s.Split(' ');

			var t = "";

			foreach (var word in words)
			{
				if (word.Length == 1)
				{
					t += word[0] + word.Substring(1) + ' ';
				}
				else
				{
					t += char.ToUpper(word[0]) + word.Substring(1) + ' ';
				}
			}
			return t;
		}

		public static T ReadJSon<T>(string path)
		{
			using (StreamReader r = new StreamReader(path))
			{
				string json = r.ReadToEnd();
				T item = JsonConvert.DeserializeObject<T>(json);
				return item;
			}
		}

		public static int TotalBill(int item1, int item2, int item3)
		{
			int sum= 0;
			sum = (item1 * 5000) + (item2 * 3000) + SumItem3(item3);
			return sum;
		}

		public static int SumItem3(int item3)
		{
			int sum_item3 = 0;
			if (item3 > 2)
			{
				sum_item3 = (item3 * 7000) - 5000;
			}
			else { sum_item3 = item3 * 5000; }
			return sum_item3;
		}
	}
}
