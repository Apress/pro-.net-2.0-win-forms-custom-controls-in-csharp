using System;
using System.Collections.Generic;
using System.Text;

namespace DataGridViewTest
{
	public static class Utility
	{
		public static string SplitStringByCase(string inputString)
		{
			if (inputString == "")
			{
				return "";
			}
			else
			{
				StringBuilder sb = new System.Text.StringBuilder();

				// Add first character.
				sb.Append(inputString[0]);

				// Add middle characters. Insert space before capitals.
				for (int i = 1; i < inputString.Length - 1; i++)
				{
					char c = inputString[i];
					// Skip existing spaces (if any).
					if (c == ' ')
					{
						sb.Append(c);
						i++;
						sb.Append(Char.ToUpper(inputString[i]));
						continue;
					}

					if (Char.IsUpper(c))
					{
						sb.Append(" ");
					}

					sb.Append(c);
				}

				// Add last character.
				sb.Append(inputString[inputString.Length - 1]);
				return sb.ToString();
			}
		}
	}
}
