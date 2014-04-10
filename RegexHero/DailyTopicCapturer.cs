using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexHero
{
    internal class DailyTopicCapturer
    {
        public IEnumerable<string> GetCurrentTopics()
        {
            using (WebClient client = new WebClient())
            {
                byte[] bytes = client.DownloadData(new Uri(@"http://www.bing.com/hpm"));
                char[] chars = new char[100 * 1024];

                int length = Encoding.UTF8.GetDecoder().GetChars(bytes, 0, bytes.Length, chars, 0);
                string tempString = new string(chars, 0, length);
                Regex regex = new Regex("<h2 class=\"hp_text\">([\\w ]+)</h2>");
                MatchCollection matches = regex.Matches(tempString);
                foreach (Match match in matches)
                {
                    yield return match.Groups[1].Value;
                }
            }
        }
    }
}
