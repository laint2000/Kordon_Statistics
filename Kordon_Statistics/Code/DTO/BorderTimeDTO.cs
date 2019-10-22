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
        private readonly static List<string> _gatesNames = new List<string>(Count) { "Ягодин-Дорогуск", "ВолодимирВолинський", "Краківець-Корчова",
                                                                "Шегині–Медика", "РаваРуська-Хребенне", "Смільниця-Кросценко", 
                                                                "Грушів-Будомєж", "Угринів-Долгобичув"};
        private readonly List<string> _gatesTime = new List<string>(Count) { "", "", "", "", "", "", "", "" };

        public DateTime CheckTime { get; set; }

        public List<string> GatesTime => _gatesTime;
        public static List<string> GatesNames => _gatesNames;
    }
}
