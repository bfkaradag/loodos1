using System;
using System.Collections.Generic;
using System.Linq;
namespace loodos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPermutate("loodos", "lds"));
            
        }
        static bool isPermutate(string str, string key)
        {
            char[] chars = str.ToCharArray();
            List<string> list = new List<string>();

            List<char> charList = new List<char>();
            charList.AddRange(chars);

            for (int i = 0; i < chars.Length; i++)
            {
                var exceptData = new List<char>(charList); 
                exceptData.RemoveAt(i);
                List<string> values = change(chars[i], exceptData.ToArray());
                list.AddRange(values);               
            }
            foreach(var x in list)
            {
                if (x.Contains(key))
                {
                    return true;
                }
            }
            return false;
        }
        static List<string> change(char c, char[] strChars) 
        {
            string str = new string(strChars);
            str = str.Insert(0, c.ToString());
            char[] chars = str.ToCharArray();

            List<string> list = new List<string>();
            list.Add(str);
            for (int i = 1; i < chars.Length - 1; i++)
            {
                char temp;
                temp = chars[i];
                chars[i] = chars[i + 1];
                chars[i + 1] = temp;
                string item = new string(chars);
                list.Add(item);

            }
           
            return list;
        }
    }
}