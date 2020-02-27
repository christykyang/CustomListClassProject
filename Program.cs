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

            CustomList<string> stringList1 = new CustomList<string>();
            stringList1.AddItem("Hello, ");
            stringList1.AddItem("my ");
            stringList1.AddItem("name ");
            stringList1.AddItem("is ");
            CustomList<string> stringList2 = new CustomList<string>();
            stringList2.AddItem("Christy");
            stringList2.AddItem(".");

            Console.WriteLine(stringList1 + stringList2);
        }
    }
}
