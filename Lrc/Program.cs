using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lrc
{
    class Program
    {
        public static Dictionary<string, string> lrcDictionary = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            string excTime = @"(?<=\[).*?(?=\])";
            string excText = @"(?<=\])(?!\[).*";
            MatchCollection matchTime;
            MatchCollection matchText;
            //读取文件所有行
            string path = @"D:\CloudMusic\朴树 - 好好地.lrc";
            string[] str = File.ReadAllLines(path, Encoding.Default);
            Dictionary<string, string> lrc = lrcDictionary.OrderBy(o => o.Key).ToDictionary(k => k.Key, v => v.Value);
            for (int i = 0; i < str.Length - 1; i++)
            {
                matchTime = Regex.Matches(str[i], excTime);
                matchText = Regex.Matches(str[i], excText);
                foreach (var s in matchTime)
                {
                    string strTemp = "";
                    foreach (var m in matchText)
                    {
                        strTemp += m;
                    }

                    if (s.ToString().Contains("."))
                    {
                        string[] tim = s.ToString().Split('.');
                        string n = tim[0] ;
                        lrcDictionary.Add(n, strTemp);
                    }
                    else
                    {
                        lrcDictionary.Add(s.ToString(), strTemp);
                    }        
              }
            }
            foreach (string key in lrcDictionary.Keys)
            {
                Console.WriteLine(key + lrcDictionary[key]);
            }

            Console.ReadKey();
        }

    }
}