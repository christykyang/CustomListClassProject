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
        private string indexOutofBounds;
        private int maxCapacity;

        //constructors
        public CustomList()
        {
            count = 0;
            maxCapacity = 4;
            arrayIndex = new T[maxCapacity];
            indexOutofBounds = "Exception: Out of bounds!";
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
                if (index <= -1)
                {
                    Console.WriteLine(indexOutofBounds);
                }
                return arrayIndex[index];
            }
            set
            {
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
                CopyItemsFromOldArraytoNewArray(newArrayIndex, arrayIndex);
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
            count--;
            //item index needs to delete 

            //shift everything following over
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(arrayIndex[i]))
                {
                    arrayIndex[i] = arrayIndex[i + 1];
                }
                else
                {
                    continue;
                }
            }
        }
        public override string ToString()
        {
            string stringResult = "";
            for (int i = 0; i < count; i++)
            {
                stringResult += arrayIndex[i].ToString();
            }
            return stringResult.ToString();
        }
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> finalList = new CustomList<T>();

            for (int i = 0; i < list1.Count; i++)
            {
                finalList.AddItem(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                finalList.AddItem(list2[i]);
            }
            return finalList;
        }
        public void RenameNewArrayAsOldArray()
        {
            arrayIndex = new T[maxCapacity];
            foreach (T index in newArrayIndex)
            {
                arrayIndex = newArrayIndex;
            }
        }
        public void CopyItemsFromOldArraytoNewArray(T[] newArrayIndex, T[] arrayIndex)
        {
            for (int i = 0; i < count; i++)
            {
                newArrayIndex[i] = arrayIndex[i];
            }
        }
        public void CreateNewArray()
        {
            maxCapacity = count * 2;
            newArrayIndex = new T[maxCapacity];
        }
    }
}
