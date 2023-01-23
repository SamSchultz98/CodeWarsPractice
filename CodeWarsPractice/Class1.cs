using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> intList = new List<int>();
        foreach (object item in listOfItems)
        {
            if (item is int)
            {
                intList.Add((int)item);
            }
        }
        return intList;

    }
}
