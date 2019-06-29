using System;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedPosList posList = new SortedPosList();
            posList.Add(new Position(6,1));
            posList.Add(new Position(9,2));
            posList.Add(new Position(5,4)); 
            posList.Add(new Position(-4,9)); 

            SortedPosList posList2 = new SortedPosList(); 
            posList.Add(new Position(6,1));
            posList.Add(new Position(9,2));
            posList.Add(new Position(5,4)); 
            posList.Add(new Position(-4,9)); 

            SortedPosList combinedList = posList + posList2; 

            Console.WriteLine(combinedList.ToString());

        }
    }
}
