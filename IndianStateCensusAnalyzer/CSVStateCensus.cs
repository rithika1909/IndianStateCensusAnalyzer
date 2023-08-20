using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace IndianStateCensusAnalyzer
{
    public class CSVStateCensus
    {
        public static int ReadStateCensusData(string filepath)
        {
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