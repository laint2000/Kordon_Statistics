using Kordon_Statistics.Code.DTO;
using System;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace Kordon_Statistics.Code
{
    public class HtmlParser : IHtmlParser
    {
        private const string NoInfo = "Інформація відсутня";

        public BorderTimeDTO Parse(string htmlText)
        {
            var result = new BorderTimeDTO()
            {
                CheckTime = DateTime.Now,
                
            };


            var section = GetSection(htmlText);

            var values = section.Select(r => new ValueDTO()
            {
                Caption = r.QuerySelector("td:first-child").InnerText,
                Time = r.QuerySelector("td:nth-child(2)").InnerText
            });

            result.GatesTime[0] = FindValueTime(values, "Ягодин");
            result.GatesTime[1] = FindValueTime(values, "Волинський");
            result.GatesTime[2] = FindValueTime(values, "Краківець");
            result.GatesTime[3] = FindValueTime(values, "Медика");
            result.GatesTime[4] = FindValueTime(values, "Рава-Руська");
            result.GatesTime[5] = FindValueTime(values, "Смільниця");
            result.GatesTime[6] = FindValueTime(values, "Грушів");
            result.GatesTime[7] = FindValueTime(values, "Угринів");

            return result;
        }

        private string FindValueTime(IEnumerable<ValueDTO> values, string keyString)
        {
            var value = values.FirstOrDefault(r => r.Caption.Contains(keyString))?.Time;

            if (value == null) return "";
            if (value == NoInfo) return "-";
            return value;
        }

        protected IEnumerable<HtmlNode> GetSection(string htmlText) 
        {
            var html = new HtmlDocument();
            html.LoadHtml(htmlText);
            var result = html.DocumentNode.QuerySelectorAll("table.responsive>tbody>tr");
            return result;
        }

        private class ValueDTO 
        { 
            public string Caption { get; set; }
            public string Time { get; set; }
        }
    }
}
