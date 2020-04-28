﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class SearchingClass
    {
		public SearchingClass(object[] array, object element, string objectType)
		{
			Element = element;
			Array = array;
			ObjectType = objectType;
		}

		private object _element;
		public object Element
		{
			get { return _element; }
			set { _element = value; }
		}

		private object[] _array;
		public object[] Array
		{
			get { return _array; }
			set { _array = value; }
		}

		private string _type;
		public string ObjectType
		{
			get { return _type; }
			set { _type = value; }
		}


		public int LinearSearch()
		{
			int len = Array.Length;
			for(int i = 0; i < len; i++)
			{
				CompareObjects op1 = new CompareObjects(Element, false, ObjectType);
				CompareObjects op2 = new CompareObjects(Array[i], false, ObjectType);
				if(op1 == op2)
				{
					return i;
				}

				//if(ObjectType == "Int")
				//{
				//	if (Convert.ToInt32(Element) == Convert.ToInt32(Array[i]))
				//	{
				//		return i;
				//	}
				//}
				//else if (ObjectType == "Float")
				//{
				//	if (Convert.ToDecimal(Element) == Convert.ToDecimal(Array[i]))
				//	{
				//		return i;
				//	}
				//}
				//else if (ObjectType == "Decimal")
				//{
				//	if (Convert.ToDouble(Element) == Convert.ToDouble(Array[i]))
				//	{
				//		return i;
				//	}
				//}
				//else if (ObjectType == "String")
				//{
				//	if (Convert.ToString(Element).Equals(Array[i]))
				//	{
				//		return i;
				//	}
				//}
			}
			return -1;
		}

		public int BinarySearch()
		{
			int l = 0, r = Array.Length - 1;
			while (l <= r)
			{
				int m = l + (r - l) / 2;

				CompareObjects op1 = new CompareObjects(Array[m], false, ObjectType);
				CompareObjects op2 = new CompareObjects(Element, false, ObjectType);
				if (op1 == op2)
					return m;
				if (op1 < op2)
					l = m + 1;
				else
					r = m - 1;
				
				//if (ObjectType == "Int")
				//{
				//	if (Convert.ToInt32(Array[m]) == Convert.ToInt32(_element))
				//		return m;
				//	if (Convert.ToInt32(Array[m]) < Convert.ToInt32(_element))
				//		l = m + 1;
				//	else
				//		r = m - 1;
				//}
				//if (ObjectType == "Float")
				//{
				//	if (Convert.ToDecimal(Array[m]) == Convert.ToDecimal(_element))
				//		return m;
				//	if (Convert.ToDecimal(Array[m]) < Convert.ToDecimal(_element))
				//		l = m + 1;
				//	else
				//		r = m - 1;
				//}
				//if (ObjectType == "Double")
				//{
				//	if (Convert.ToDouble(Array[m]) == Convert.ToDouble(_element))
				//		return m;
				//	if (Convert.ToDouble(Array[m]) < Convert.ToDouble(_element))
				//		l = m + 1;
				//	else
				//		r = m - 1;
				//}
				//if (ObjectType == "String")
				//{
				//	if (Convert.ToString(Array[m]) == Convert.ToString(_element))
				//		return m;
				//	if (Convert.ToString(Array[m]).CompareTo(Convert.ToString(_element)) < 0)
				//		l = m + 1;
				//	else
				//		r = m - 1;
				//}
			}

			return -1;
		}
	}
}