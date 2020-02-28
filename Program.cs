using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> numbersList1 = new CustomList<int>();
            numbersList1.AddItem(24);
            numbersList1.AddItem(30);
            numbersList1.AddItem(2);

            CustomList<int> numbersList2 = new CustomList<int>();
            numbersList2.AddItem(2);
            numbersList2.AddItem(1);

            CustomList<int> finalNumbersList = new CustomList<int>();

            finalNumbersList = numbersList1 - numbersList2;
            Console.WriteLine(finalNumbersList);
        }
    }
}
