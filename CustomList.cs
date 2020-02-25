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
        private T[] newArrayIndex;
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
            //count == maxcapacity, we need to increase capacity and copy
            if (count == maxCapacity)
            {
                //increase capacity
                CreateNewArray();
                //copy
                CopyItemsFromOldArraytoNewArray(newArrayIndex);
                //new array is renamed
                RenameNewArrayAsOldArray();
                arrayIndex[count] = item;
                count++;

            }
            else
            {
                //item needs to land at the next avaliable index
                //check to make sure it persists
                arrayIndex[count] = item;
                //increment count
                count++;
            }
        }
        public void RemoveItem(T item)
        {
            //count decreases

            //index of item removed list over
        }
        public void RenameNewArrayAsOldArray()
        {
            arrayIndex = new T[maxCapacity];
            arrayIndex = newArrayIndex;
        }
        public void CopyItemsFromOldArraytoNewArray(Array newArrayIndex)
        {
            foreach (T index in arrayIndex)
            {
                newArrayIndex = arrayIndex;
            }
        }
        public void CreateNewArray()
        {
            maxCapacity = count * 2;
            newArrayIndex = new T[maxCapacity];
        }
    }
}
