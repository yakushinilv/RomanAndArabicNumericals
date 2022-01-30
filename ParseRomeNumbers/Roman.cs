using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanAndArabicNumericals
{
    internal class Roman
    {
        public string ConvertToRomanNumericals(string input)
        {
            string outputString = String.Empty;
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "I", "V" });
            list.Add(new string[] { "X", "L" });
            list.Add(new string[] { "C", "D" });
            list.Add(new string[] { "M", "" });
            int j = 0;
            List<string> romanList = new List<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string str = input[i].ToString();

                if (str != "0")
                {
                    string output = string.Empty;
                    int count = Convert.ToInt32(str) - 5;
                    if (count > 0 && count < 4)
                    {
                        output += list[j][1];
                        for (int k = 0; k < count; k++)
                            output += list[j][0];
                    }
                    else if (count == 4)
                    {
                        output += $"{list[j][0]}{list[j + 1][0]}";
                    }
                    else if (count == 0)
                        output += list[j][1];
                    else if (count < 0 && count < -1)
                    {
                        for (int k = 0; k < Convert.ToInt32(str); k++)
                            output += list[j][0];
                    }
                    else if (count == -1)
                    {
                        output += $"{list[j][0]}{list[j][1]}";
                    }
                    romanList.Add(output);
                }


                j++;

            }

            romanList.Reverse();
            outputString = string.Join("", romanList);
            return outputString;
        }
    }
}
