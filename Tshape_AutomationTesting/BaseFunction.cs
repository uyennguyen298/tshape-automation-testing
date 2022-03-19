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

	}
}
