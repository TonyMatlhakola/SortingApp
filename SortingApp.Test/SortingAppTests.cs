using System;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace SortingApp.Test
{
    public class SortingAppTests
    {
        [Fact]
        public void DiscardPunctuationTest()
        {
            //arrange
            string textToAnalyze = "353oihehfw7854@#$@%@#RQSFAsvaS>AAD<G>SDGg.sd.gsdsdg.sdgs";
            var stringAnalyser = new StringAnalyser();

            //act
            var analyzedText = stringAnalyser.DiscardPunctuation(textToAnalyze);
             textToAnalyze = Regex.Replace(textToAnalyze, @"[^A-Za-z]", string.Empty).ToLower();

            //assert            
            Assert.Equal(analyzedText, textToAnalyze);

        }
        [Fact]
        public void QuickSortTextTest()
        {
            //arrange
            string textToAnalyze = "oihehfwrqsfasvasaadgsdggsdgsdsdgsdgs";
            string expectedSortedText = "aaaaddddddeffgggggghhioqrsssssssssvw";
            char[] charArr = textToAnalyze.ToCharArray();

            //act
            var sortedText = QuickSort.QuickSortString(charArr);

            //assert
            Assert.Equal(expectedSortedText, sortedText);

        }


    }
}
