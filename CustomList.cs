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
        private T[] arrayIndex;
        //private int indexLocation;
        private int maxCapacity;
        
        //constructors
        public CustomList()
        {
            count = 0;
            maxCapacity = 4;
            arrayIndex = new T[maxCapacity];
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int index]
        {
            get
            {
                return arrayIndex[index];
            }
            set
            {
                //if (value = )
                //{

                //}
                arrayIndex[index] = value;
            }
        }
        public int MaxCapacity
        {
            get
            {
                return maxCapacity;
            }
            set
            {
                maxCapacity = 4;
            }
        }
        //member methods
        public void AddItem(T item)
        {
            //increment count
            //count++;

            //item needs to land at next available index
            arrayIndex[count] = item;
            count++;

            //for (int i = 0; i < maxCapacity; i++)
            //{
            //    if (maxCapacity <= 3)
            //    {
                    
            //    }
            //    else
            //    {

            //    }
            //}
            
            
            //while (maxCapacity <= 3)
            //{
                
            //}
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
