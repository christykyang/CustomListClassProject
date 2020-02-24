using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_SingleItem_ToCustomList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            //Act
            list.AddItem(24);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Add_CheckIndexOfFirstItem()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 24;

            //Act
            list.AddItem(expected);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_CheckIndexOfNextItem()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int numberOne = 24;
            int numberTwo = 30;
            int expected = 30;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void AddIndexOutOrRange()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;
            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);
            //Assert
            Assert.AreEqual(expected, list[4]);
        }
        [TestMethod]
        public void CheckCountAfterCopy()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 5;
            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void CopyOriginalArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            //int[] integersInArray = { 24, 30, 2 };
            int expected = 24;
            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);
            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Remove_ItemFromCustomList()
        {
            //Arrrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int numberOne = 24;
            int numberTwo = 30;
            int numberThree = 2;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);
            list.AddItem(numberThree);
            list.RemoveItem(2);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void RemoteItem_CheckIfIndexZero()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 30;
            int numberOne = 24;
            int numberTwo = 30;
            int numberThree = 2;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);
            list.AddItem(numberThree);
            list.RemoveItem(24);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void RemoveItem_CheckIndexOne() 
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int numberOne = 24;
            int numberTwo = 30;
            int numberThree = 2;
            int expected = 2;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);
            list.AddItem(numberThree);
            list.RemoveItem(30);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void RemoveTwoItems_CheckIfIndexMoves()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            //int[] integersInArray = { 24, 30, 2 };
            int expected = 8;
            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);
            list.RemoveItem(24);
            list.RemoveItem(5);
            //Assert
            Assert.AreEqual(expected, list[2]);
        }
    }
}
