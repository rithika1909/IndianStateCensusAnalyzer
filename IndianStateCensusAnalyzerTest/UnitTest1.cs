using IndianStateCensusAnalyzer;

namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusData.csv";
        [Test]
        public void GivenStateCensusData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCensusAnalyzer.ReadStateCensusData(stateCensusDataFilePath),
                CSVStateCensus.ReadStateCensusData(stateCensusDataFilePath));
        }
    }
}