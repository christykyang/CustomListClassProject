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
            CustomList<int> list = new CustomList<int>();
            list.AddItem(24);
            list.AddItem(30);
            //list.AddItem(2);
            //list.AddItem(5);
            //list.AddItem(8);
            //list.ToString();

            Console.WriteLine(list.ToString());
        }
    }
}
