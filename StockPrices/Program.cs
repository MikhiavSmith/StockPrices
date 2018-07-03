using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPrices
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] prices = { 7, 1, 5, 3, 6, 4 };
			int m = MaxProfit(prices);
			Console.WriteLine(m);
			Console.ReadLine();
		}

		public static int MaxProfit(int[] prices)
		{
			int maxP = 0;
			int min = prices[0];
			for (int i = 1; i < prices.Length; i++)
			{
				
				if (min < prices[i])
				{
					int diff = prices[i] - min;
					if (diff > maxP)
						maxP = diff;
				}
				for (int j = i + 1; j < prices.Length; j++)
				{
					if (prices[i] < prices[j])
					{
						int diff2 = prices[j] - prices[i];
						if (diff2 > maxP)
						{
							maxP = diff2;
						}
					}
				}

			}
			return maxP;
		}
	}
}
