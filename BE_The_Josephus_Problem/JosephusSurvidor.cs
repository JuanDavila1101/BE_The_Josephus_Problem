using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_The_Josephus_Problem
{
  public class JosephusSurvivor
  {
    public string Survivor(List<string> listOfString, int jumpByNubmer)
    {
      var lenghtOfList = listOfString.Count;
      var subNumber = 0;

      for (int i = 1; i <= lenghtOfList; i++)
      {
        subNumber = (subNumber + jumpByNubmer) % i;
      }
      return listOfString[subNumber];
    }

  }
}
