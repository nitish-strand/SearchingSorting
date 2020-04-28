using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    public class CompareObjects
    {
        Object element;
        bool result;
        String ObjectType;

        public CompareObjects() 
        { 
            element = 0;
            result = false;
            ObjectType = "String";
        }
        public CompareObjects(Object elem, bool res, String type) 
        {
            element = elem;
            result = res;
            ObjectType = type;
        }


        //op1 is equal to op2
        public static bool operator ==(CompareObjects op1, CompareObjects op2)
        {
            if(op1.ObjectType == "Int")
            {
                // op1 is equals to op2
                if (Convert.ToInt32(op1.element) == Convert.ToInt32(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Float")
            {
                if (Convert.ToDecimal(op1.element) == Convert.ToDecimal(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Double")
            {
                if (Convert.ToDouble(op1.element) == Convert.ToDouble(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Convert.ToString(op1.element).CompareTo(Convert.ToString(op2.element)) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        // op1 is not equals to op2
        public static bool operator !=(CompareObjects op1, CompareObjects op2)
        {
            if (op1.ObjectType == "Int")
            {
               
                if (Convert.ToInt32(op1.element) == Convert.ToInt32(op2.element))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (op1.ObjectType == "Float")
            {
                if (Convert.ToDecimal(op1.element) == Convert.ToDecimal(op2.element))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (op1.ObjectType == "Double")
            {
                if (Convert.ToDouble(op1.element) == Convert.ToDouble(op2.element))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (Convert.ToString(op1.element).CompareTo(Convert.ToString(op2.element)) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        // op1 is more than op2
        public static bool operator >(CompareObjects op1, CompareObjects op2)
        {
            if (op1.ObjectType == "Int")
            {
                
                if (Convert.ToInt32(op1.element) > Convert.ToInt32(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Float")
            {
                if (Convert.ToDecimal(op1.element) > Convert.ToDecimal(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Double")
            {
                if (Convert.ToDouble(op1.element) > Convert.ToDouble(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Convert.ToString(op1.element).CompareTo(Convert.ToString(op2.element)) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        // op1 is less than op2
        public static bool operator <(CompareObjects op1, CompareObjects op2)
        {
            if (op1.ObjectType == "Int")
            {
                
                if (Convert.ToInt32(op1.element) < Convert.ToInt32(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Float")
            {
                if (Convert.ToDecimal(op1.element) < Convert.ToDecimal(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Double")
            {
                if (Convert.ToDouble(op1.element) < Convert.ToDouble(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Convert.ToString(op1.element).CompareTo(Convert.ToString(op2.element)) < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        // op1 is more than equal to op2
        public static bool operator >=(CompareObjects op1, CompareObjects op2)
        {
            if (op1.ObjectType == "Int")
            {

                if (Convert.ToInt32(op1.element) >= Convert.ToInt32(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Float")
            {
                if (Convert.ToDecimal(op1.element) >= Convert.ToDecimal(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Double")
            {
                if (Convert.ToDouble(op1.element) >= Convert.ToDouble(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Convert.ToString(op1.element).CompareTo(Convert.ToString(op2.element)) >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        // op1 is less than equal to op2
        public static bool operator <=(CompareObjects op1, CompareObjects op2)
        {
            if (op1.ObjectType == "Int")
            {

                if (Convert.ToInt32(op1.element) <= Convert.ToInt32(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Float")
            {
                if (Convert.ToDecimal(op1.element) <= Convert.ToDecimal(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (op1.ObjectType == "Double")
            {
                if (Convert.ToDouble(op1.element) <= Convert.ToDouble(op2.element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Convert.ToString(op1.element).CompareTo(Convert.ToString(op2.element)) <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
