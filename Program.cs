using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning
{
	class Program
	{
		static void Main()
		{
			int count, i, j;
			string Alphabet;
			for (i = 0; i < 26; ++i)
			{
				Alphabet = "";
				Alphabet += (char)(65 + i) + "\t";
				for (j = 0; j <= i; ++j)
				{
					Alphabet += "  ";
					//알파벳 앞에 들어갈 공백을 배열에 입력받는다.
				}
				count = i * 3;
				for (j = i; j < 26; ++j)
				{
					Alphabet += (char)(65 + count / 3);
					count++;
				}
				Console.WriteLine(Alphabet);
			}
		}
	}
}