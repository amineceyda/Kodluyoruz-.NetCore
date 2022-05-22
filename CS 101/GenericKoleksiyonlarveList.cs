using System;
using System.Collections.Generic;

namespace GenericKoleksiyonlarveList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
			List<int> numberList = new List<int>();

			numberList.Add(10);
			numberList.Add(11);
			numberList.Add(12);
			numberList.Add(13);
			numberList.Add(14);
			numberList.Add(15);
			numberList.Add(16);

			List<string> colorList = new List<string>();

			colorList.Add("Red");
			colorList.Add("Green");
			colorList.Add("Blue");
			colorList.Add("White");
			colorList.Add("Black");


			//Count
			Console.WriteLine(numberList.Count);
			Console.WriteLine(colorList.Count);

			//Foreach And List.ForEach
			foreach (var item in numberList)
				Console.WriteLine(item);
			foreach (var item in colorList)
				Console.WriteLine(item);

			numberList.ForEach(item => Console.WriteLine(item));
			colorList.ForEach(item => Console.WriteLine(item));

			//Removing An Element From The List
			numberList.Remove(10);
			colorList.Remove("Red");

			numberList.ForEach(item => Console.WriteLine(item));
			colorList.ForEach(item => Console.WriteLine(item));

			numberList.RemoveAt(0);
			colorList.RemoveAt(0);

			numberList.ForEach(item => Console.WriteLine(item));
			colorList.ForEach(item => Console.WriteLine(item));

			//Search Contains()
			if (numberList.Contains(11))
				Console.WriteLine("There are 11 numbers on the list");

			//Access Index By Value
			Console.WriteLine(numberList.BinarySearch(12));

			//Convert Array To List
			string[] animals = { "Cat", "Dog", "Bird" };

			List<string> newList = new List<string>(animals);

			//Clearing The List
			newList.Clear();

			//Keep An Object In The List
			List<Users> userList = new List<Users>();

			Users users1 = new Users();
			users1.UName = "NAME";
			users1.USurname = "SURNAME";
			users1.UAge = 123;

			Users users2 = new Users();
			users2.UName = "NAME2";
			users2.USurname = "SURNAME2";
			users2.UAge = 1232;

			userList.Add(users1);
			userList.Add(users2);

			List<Users> newUserList = new List<Users>();
			newUserList.Add(new Users()
			{
				UName = "NAME3",
				USurname = "SURNAME3",
				UAge = 1233
			});

			foreach (var item in userList)
			{
				Console.WriteLine(item.UName);
				Console.WriteLine(item.USurname);
				Console.WriteLine(item.UAge);
			}
		}
    }
	public class Users
	{
		private string uName;

		private string uSurname;

		private int uAge;

		public string UName { get => uName; set => uName = value; }
		public string USurname { get => uSurname; set => uSurname = value; }
		public int UAge { get => uAge; set => uAge = value; }
	}
}