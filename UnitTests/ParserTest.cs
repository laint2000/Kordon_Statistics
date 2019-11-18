using System;
using Kordon_Statistics.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics.Fakes;

namespace UnitTests
{
    [TestClass]
    public class ParserTest
    {

        [TestMethod]
        public void Parse_MustReturn_ValidGateTime()
        {
            //arrange
            var parser = new HtmlParser();
            var fileName = @"../../../TestData/UaPol.html";
            var connector = new HttpConnectorFake(fileName);

            //act
            var value = parser.Parse(connector.LoadString(""));
            
            //assert
            var validTimes = new string[] { "", "00:00", "00:12", "", "00:10", "00:10", "00:22", "00:00" };

            var gatesTimeList = value.GatesTimeList;
            for (var i = 0; i < gatesTimeList.Count; i++)
            {
                Assert.AreEqual(validTimes[i], gatesTimeList[i], $@"value.GatesTime[{i}] is invalid");
            }
        }
    }
}