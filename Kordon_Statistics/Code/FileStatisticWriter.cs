using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kordon_Statistics.Code.DTO;

namespace Kordon_Statistics.Code
{
    class FileStatisticWriter : IFileStatisticWriter
    {
        private const string fieldDelimiter = "\t";
        private string _fileName;

        public FileStatisticWriter(string fileName)
        {
            _fileName = fileName;
        }

        public bool AppendValue(BorderTimeDTO valueUaPol)
        {
            var valueString =  getCommaSeparatedString(valueUaPol);

            using (var writer = CreateOrOpenFile(_fileName)) {
                writer.WriteLine(valueString);
                writer.Flush();
            }

            return true; 
        }

        private StreamWriter CreateOrOpenFile(string fileName) 
        {
            return File.Exists(fileName) 
                ? File.AppendText(fileName) 
                : CreateFileWithHeaders(fileName);
        }

        private StreamWriter CreateFileWithHeaders(string fileName)
        {
            var fileWriter = File.CreateText(fileName);

            var valuesHeadere = string.Join(fieldDelimiter, BorderTimeDTO.GatesNames);
            var header = $"Час{fieldDelimiter}{valuesHeadere}";

            fileWriter.WriteLine(header);
            return fileWriter;
        }

        private object getCommaSeparatedString(BorderTimeDTO val)
        {
            var values = string.Join(fieldDelimiter, val.GatesTime);
            return $"{val.CheckTime}{fieldDelimiter}{values}";
        }
    }
}
