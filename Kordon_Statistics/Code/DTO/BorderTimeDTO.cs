using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordon_Statistics.Code.DTO
{
    public class BorderTimeDTO
    {
        public readonly static int Count = 8;
        private readonly static string[] _gatesHeaders = new string[] { "Краківець", "Шегині", "Грушів", "РаваРуська",
                                                                       "Ягодин", "В.Волинський", "Смільниця", "Угринів"};
        private readonly Dictionary<string, string> _gatesTime = new Dictionary<string, string>();

        public DateTime CheckTime { get; set; }

        public Dictionary<string, string> GatesTime => _gatesTime;
        public List<string> GatesTimeList => _gatesTime.OrderBy(r => Array.IndexOf(GatesNames.List, r.Key)).Select(r => r.Value).ToList();
        public static string[] GatesHeaders => _gatesHeaders;
    }
}
