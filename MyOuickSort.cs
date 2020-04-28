using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class MyOuickSort
    {
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

		private int low;
		private int high;

		public MyOuickSort(object[] myArray, int low , int high, string objectType)
		{
			this.low = low;
			this.high = high;
			MyArray = myArray;
			ObjectType = objectType;
			quickSort(myArray, low, high);
		}

		private int partition(object[] arr, int low, int high)
		{
			object pivot = arr[high];

			int i = (low - 1);
			for (int j=low; j <high; j++)
			{
				CompareObjects op1 = new CompareObjects(arr[j], false, ObjectType);
				CompareObjects op2 = new CompareObjects(pivot, false, ObjectType);

				if (op1 < op2)
				{
					i++;

					object temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}

			object temp1 = arr[i + 1];
			arr[i + 1] = arr[high];
			arr[high] = temp1;

			return i + 1;
		}

		public object[] quickSort(object[] arr, int low, int high)
		{
			if (low < high)
			{
				int pi = partition(arr, low, high);

				quickSort(arr, low, pi - 1);
				quickSort(arr, pi + 1, high);
			}
			
			return MyArray;
		}
	}
}
