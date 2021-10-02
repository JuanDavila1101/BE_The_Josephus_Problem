using System;
using System.Collections.Generic;
using Xunit;

namespace BE_The_Josephus_Problem.Tests
{
  public class JosephusSurvivorTest
  {
    public static IEnumerable<object[]> GenerateData()
    {
      return new List<object[]>
      {
        new object []
        {
          new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" },
          3,
          "4"
        },
        new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          1,
          "Han"
        },
        new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          2,
          "Stewart"
        },
        new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          3,
          "Mike"
        },
        new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          4,
          "Stewart"
        },
         new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          5,
          "Jeorge"
        },
        new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          6,
          "Jeorge"
        },
         new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          7,
          "Luke"
        },
        new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          8,
          "Juan"
        },
         new object []
        {
          new List<string> { "Juan", "David", "Jeorge", "Mike", "Stewart", "Samuel", "Miguel", "Francis", "Luke", "Han" },
          9,
          "Miguel"
        },
      };
    }

    [Theory]
    // This will not work for this
    //[InlineData(new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }, 3, "4")]
    [MemberData(nameof(GenerateData))]
    public void Luck_for_the_Josephus_survivor(List<string> listOfItems, int jumpByNumber, string expected)
    {
      var josephusSurvivor = new JosephusSurvivor();
      var survived = josephusSurvivor.Survivor(listOfItems, jumpByNumber);
      Assert.Equal(expected, survived);
    }



  }
}
