using System;
using Kordon_Statistics.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics.Fakes;

namespace UnitTests
{
    [TestClass]
    public class ParserTest
    {
        private HtmlParser _parser;
        private HttpConnectorFake _fakeConnector;

        [TestInitialize]
        public void SetUp() 
        {
            _parser = new HtmlParser();
            _fakeConnector = new HttpConnectorFake();
        }

        [TestMethod]
        public void Parse_MustReturn_ValidGateTime()
        {
            //arrange
            var fileName = @"../../../TestData/UaPol.html";
            var htmlText = _fakeConnector.LoadString(fileName);

            //act
            var value = _parser.Parse(htmlText);

            //assert
            var actual = value.GatesTimeList;
            var expected = new string[] { "", "00:00", "00:12", "", "00:10", "00:10", "00:22", "00:00" };

            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i], $"value.GatesTime[{i}] is invalid");
            }
        }
    }
}