using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MusicPlayer
{
    class Lrc
    {
        private Dictionary<string, string> lrcCollections;
        public Dictionary<string, string> LrcCollection
        {
            get { return lrcCollections; }
            set { }//只读
        }
        public Lrc(string path)
        {
            if (File.Exists(path) == false)
            {
                throw new System.ArgumentException("歌词文件不存在");
            }
            getLrcContext(path);
        }
        private void getLrcContext(string path)
        {
            lrcCollections = new Dictionary<string, string>();
            //正则表达式 元字符
            string excTime = @"(?<=\[).*?(?=\])";
            string excText = @"(?<=\])(?!\[).*";
            //正则表达式匹配结果集合
            MatchCollection matchTime;
            MatchCollection matchText;
            //读取歌词内容存入
            string[] str = File.ReadAllLines(path);
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
                    try
                    {
                        lrcCollections.Add(s.ToString(), strTemp);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

    }

   }
