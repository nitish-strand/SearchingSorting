using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class MyBubbleSort
    {
		public MyBubbleSort(object[] array, string type)
		{
			_myArray = array.ToArray();
			_type = type;
			bubbleSort();
		}
		private object[] _myArray;
		public object[] MyArray
		{
			get { return _myArray; }
			set { _myArray = value.ToArray(); }
		}

		private string _type;
		public string ObjectType
		{
			get { return _type; }
			set { _type = value; }
		}


		public object[] bubbleSort()
		{
			int n = MyArray.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					CompareObjects op1 = new CompareObjects(MyArray[j], false, ObjectType);
					CompareObjects op2 = new CompareObjects(MyArray[j + 1], false, ObjectType);

					if (op1 > op2) swap(i, j);
				}

			}
			
			return MyArray;
		}

		private void swap(int i, int j)
		{
			// swap temp and arr[i] 
			object temp = MyArray[j];
			MyArray[j] = MyArray[j + 1];
			MyArray[j + 1] = temp;
		}

	}
}
