using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace IndianStateCensusAnalyzer
{
    public class CSVStateCensus
    {
        public static int ReadStateCensusData(string filepath)
        {
            if(!File.Exists(filepath))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.FILE_NOT_EXISTS, "File not exists");
            }
            if (!Path.GetExtension(filepath).Equals(".csv"))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.FILE_INCORRECT,
                    "File extension incorrect");
            }
            if (File.ReadAllLines(filepath)[0].Equals("SrNo,State,Name,TIN,StateCode"))
            {
                throw new CensusAnalyzerException(CensusAnalyzerException.ExceptionType.DELIMITER_INCORRECT, "Delimeter Incorrect");
            }

            using (var reader = new StreamReader(filepath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusData>().ToList();
                    return records.Count() - 1;
                }
            }


        }
    }
}