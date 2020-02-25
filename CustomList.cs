using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        private int count;
        private int indexLocation;
        private int maxCapacity;
        //constructors
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = 0;
            }
        }
        public int IndexLocation
        {
            get
            {
                return indexLocation;
            }
            set
            {
                indexLocation = -1;
            }
        }
        //public int MaxCapacity
        //{
            
        //}
        //member methods
        public void AddItem(T item)
        {
            //increment count
            count++;

            //item needs to land at next available index
            //indexLocation++;

            //check to make sure it persists


            //count == maxcapacity, we need to increase capacity and copy
        }
        public void RemoveItem(T item)
        {
            //count decreases

            //index of item removed list over
        }
    }
}
