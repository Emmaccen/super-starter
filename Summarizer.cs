using System;
using System.Collections.Generic;
using System.Text;

namespace ChangingTheWorld
{
    class Summarizer
    {
        public static string summerizer(int maxLength, String text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (text.Length > maxLength)
            {
                String[] split = text.Split(' ');
                int count = 0;
                String summary = "";
                foreach (var word in split)
                {
                    count += word.Length + 1;
                    summary += word + " ";
                    if (count > maxLength)
                    {
                        stringBuilder.Append(summary).Append("...");
                        break;
                    }
                }
                return stringBuilder.ToString();
            }
            else
            {
                return text;
            }
        }
    }
}
