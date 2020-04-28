using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    class MyBinarySearch
    {
        private object element;
        public object Element
        {
            get { return element; }
            set { element = value; }
        }

        private object[] arr;
        public object[] Array
        {
            get { return arr; }
            set { arr = value; }
        }

        private string _type;
        public string ObjectType
        {
            get { return _type; }
            set { _type = value; }
        }



        // For this to happen array must be sorted insert later
        public int BinarySearch()
        {
            int l = 0, r = Array.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if(ObjectType == "Int")
                {
                    if (Convert.ToInt32(arr[m]) == Convert.ToInt32(element))
                        return m;
                    if (Convert.ToInt32(arr[m]) < Convert.ToInt32(element))
                        l = m + 1;
                    else
                        r = m - 1;
                }
                if (ObjectType == "Float")
                {
                    if (Convert.ToDecimal(arr[m]) == Convert.ToDecimal(element))
                        return m;
                    if (Convert.ToDecimal(arr[m]) < Convert.ToDecimal(element))
                        l = m + 1;
                    else
                        r = m - 1;
                }
                if (ObjectType == "Double")
                {
                    if (Convert.ToDouble(arr[m]) == Convert.ToDouble(element))
                        return m;
                    if (Convert.ToDouble(arr[m]) < Convert.ToDouble(element))
                        l = m + 1;
                    else
                        r = m - 1;
                }
                if (ObjectType == "String")
                {
                    if (Convert.ToString(arr[m]) == Convert.ToString(element))
                        return m;
                    if (Convert.ToString(arr[m]).CompareTo(Convert.ToString(element)) < 0)
                        l = m + 1;
                    else
                        r = m - 1;
                }
            }

            return -1;
        }
    }
}