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

        public string StateCodeDataFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCode.csv";
        public string StateCodeDataIncorrectFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCode.txt";
        public string StateCodeDataNoFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\StateCodeDatas.cs";
        public string StateCodeDataHeaderFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCodeHeader.csv";
        public string StateCodeDataDelimiterFilePath = @"D:\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\Files\StateCodeDelimiter.csv";

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

        [Test]
        public void GivenStateCode_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCodeCensus.ReadStateCodeData(StateCodeDataFilePath),37);
        }
        [Test]
        public void GivenStateCodeFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeCensus.ReadStateCodeData(StateCodeDataIncorrectFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File Extension incorrect");
            }
        }
        [Test]
        public void GivenStateCodeFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeCensus.ReadStateCodeData(StateCodeDataNoFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "File Not Exists");
            }
        }
        [Test]
        public void GivenStateCodeFileHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeCensus.ReadStateCodeData(StateCodeDataHeaderFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
        [Test]
        public void GivenStateCodeFileDelimiterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeCensus.ReadStateCodeData(StateCodeDataDelimiterFilePath);
            }
            catch (CensusAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Delimiter Incorrect");
            }
        }
    }

}