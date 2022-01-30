using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanAndArabicNumericals
{
    internal class Arabic
    {
        private List<KeyValuePair<string, int>> Data = new List<KeyValuePair<string, int>>()
        {
        new KeyValuePair<string, int>("I",1),
        new KeyValuePair<string, int>("V",5),
        new KeyValuePair<string, int>("X",10),
        new KeyValuePair<string, int>("L",50),
        new KeyValuePair<string, int>("C",100),
        new KeyValuePair<string, int>("D",500),
        new KeyValuePair<string, int>("M",1000),
        };

        private  int GetValue(string input)
        {

            foreach (var item in Data)
                if (item.Key == input)
                    return item.Value;

            return 0;
        }
        public string ConvertToArabicNumericals(string input)
        {
            int result = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < input.Length; i++)
                list.Add(GetValue(input[i].ToString()));

            for (int i = 0; i < list.Count; i++)
            {
                int current = list[i];
                if (i + 1 < list.Count)
                {

                    int next = list[i + 1];
                    if (current >= next) result += current;
                    if (current < next)
                    {
                        result += next - current;
                        i++;
                    }


                }
                else
                    result += current;
            }

            return result.ToString();
        }
    }
}
