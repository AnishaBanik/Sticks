using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("enter no of sticks");
		int nos = Convert.ToInt32(Console.ReadLine());
		int i;
		int[] len = new int[nos];
		Console.WriteLine("enter lengths of sticks");
		for (i = 0; i < nos; i++)
		{
			len[i] = Convert.ToInt32(Console.ReadLine());
		}
		Array.Sort(len);
		int j;
		int[] ans = new int[nos+1];
		int p = 0, n, k = 0;
		while (nos >= 0)
		{
			ans[p] = nos;
			p++;
			n = 1;

			while (n < nos)
			{
				if (len[n] != len[0])
					break;
				n++;
			}
			for (j = n; j < nos; j++)
			{
				len[j] = len[j] - len[0];
			}

			for (j = n; j < nos; j++)
			{
				len[k++] = len[j];
			}
			k = 0;
			nos -= n;
			
		}

		for (i = 0; i < p; i++)
			Console.Write(ans[i] + " ");
	}
}
