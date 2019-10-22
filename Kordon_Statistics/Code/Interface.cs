using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kordon_Statistics.Code.DTO;

namespace Kordon_Statistics.Code
{
    interface IHtmlParser
    {
        DTO.BorderTimeDTO Parse(string htmlText);
    }

    interface IFileStatisticWriter
    {
        bool AppendValue(BorderTimeDTO value);
    }
}
