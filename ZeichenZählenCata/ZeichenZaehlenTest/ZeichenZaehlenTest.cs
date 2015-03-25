namespace ZeichenZaehlenTest
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using ZeichenZaehlen;

    /// <summary>
    /// TestMethods
    /// </summary>
    [TestClass]
    public class ZeichenZaehlenTest
    {
        [TestMethod]
        public void ZaehleZeichenTestGutenAbend()
        {
            //Arrange
            var counter = new Counter();
            const string wordToCountSignsFrom = "Guten Abend";
            var expectedDict = new Dictionary<string, int>()
            {
                {"G",1},{"u",1},{"t",1},{"e",2},{"n",2},{" ",1},{"A",1},{"b",1},{"d",1}
            };

            //Act
            var testDict = counter.CountCharactersOf(wordToCountSignsFrom);

            //Assert
            testDict.Should().NotBeNull();
            expectedDict.ShouldAllBeEquivalentTo(testDict);
        }

        [TestMethod]
        public void ZaehleZeichenTestHallo()
        {
            //Arrange
            var counter = new Counter();
            const string wordToCountSignsFrom = "Hallo";
            var expectedDict = new Dictionary<string, int>()
            {
                {"H",1},{"a",1},{"l",2},{"o",1}
            };

            //Act
            var testDict = counter.CountCharactersOf(wordToCountSignsFrom);

            //Assert
            testDict.Should().NotBeNull();
            expectedDict.ShouldAllBeEquivalentTo(testDict);
        }
    }
}