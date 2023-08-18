using IndianStateCensusAnalyzer;

namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusData.csv";
        public string stateCensusDataIncorrectFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusData.txt";
        public string stateCensusDataNoFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensus.csv";
        public string stateCensusDataHeaderFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusDataHeader.csv";
        public string stateCensusDataDelimiterFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCensusDataDelimiter.csv";
        public void GivenStateCensusData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCensusAnalyzer.ReadStateCensusData(stateCensusDataFilePath),
                CSVStateCensus.ReadStateCensusData(stateCensusDataFilePath));
        }
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataIncorrectFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }
        }
        [Test]
        public void GivenStateCensusDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataNoFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }
        }
        [Test]
        public void GivenStateCensusDataFileHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataHeaderFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Header incorrect");
            }
        }
        [Test]
        public void GivenStateCensusDataFileDelimiterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyzer.ReadStateCensusData(stateCensusDataDelimiterFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter incorrect");
            }
        }
    }

}