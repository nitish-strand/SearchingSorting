using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class MyMergeSort
    {
        public MyMergeSort(object[] array, string dataType, int arraySize)
        {
            MyArray = array;
            ObjectType = dataType;
            int p = 0;
            int r = arraySize - 1;
            mergeSort(MyArray, p, r);
        }

        private object[] _array;    
        public object[] MyArray
        {
            get { return _array; }
            set { _array = value.ToArray(); }
        }

        private string _type;
        public string ObjectType
        {
            get { return _type; }
            set { _type = value; }
        }

        private void mergeSort(object[] MyArray, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(MyArray, p, q);
                mergeSort(MyArray, q + 1, r);
                merge(MyArray, p, q, r);
            }
        }

        private void merge(object[] MyArray, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            object[] L = new object[n1];
            object[] R = new object[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = MyArray[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = MyArray[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                CompareObjects op1 = new CompareObjects(L[i], false, ObjectType);
                CompareObjects op2 = new CompareObjects(R[j], false, ObjectType);

                if(op1 <= op2)
                {
                    MyArray[k] = L[i];
                    i++;
                }
                else
                {
                    MyArray[k] = R[j];
                    j++;
                }
                k++;

                //if(ObjectType == "Int")
                //{
                //    if (Convert.ToInt32(L[i]) <= Convert.ToInt32(R[j]))
                //    {
                //        MyArray[k] = L[i];
                //        i++;
                //    }
                //    else
                //    {
                //        MyArray[k] = R[j];
                //        j++;
                //    }
                //    k++;
                //}
                //if (ObjectType == "Float")
                //{
                //    if (Convert.ToDecimal(L[i]) <= Convert.ToDecimal(R[j]))
                //    {
                //        MyArray[k] = L[i];
                //        i++;
                //    }
                //    else
                //    {
                //        MyArray[k] = R[j];
                //        j++;
                //    }
                //    k++;
                //}
                //if (ObjectType == "Double")
                //{
                //    if (Convert.ToDouble(L[i]) <= Convert.ToDouble(R[j]))
                //    {
                //        MyArray[k] = L[i];
                //        i++;
                //    }
                //    else
                //    {
                //        MyArray[k] = R[j];
                //        j++;
                //    }
                //    k++;
                //}
                //else
                //{
                //    if (Convert.ToString(L[i]).CompareTo(Convert.ToString(R[j])) <= 0)
                //    {
                //        MyArray[k] = L[i];
                //        i++;
                //    }
                //    else
                //    {
                //        MyArray[k] = R[j];
                //        j++;
                //    }
                //    k++;
                //}

            }
            while (i < n1)
            {
                MyArray[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                MyArray[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
