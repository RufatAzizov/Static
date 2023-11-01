using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3110
{
    public class Student
    {

        private static int studentCount = 0;

        public int Id { get; }
        private string _fullname;
        private string _groupNo;
        private byte _age;

        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (CheckFullname(value))
                {
                    _fullname = value;
                }
                else
                {
                    Console.WriteLine("Please write full name in correct form");
                }
            }
        }

        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
                else
                {
                    Console.WriteLine("GroupNo must contain 1 letter and 3 numbers. Example: 840i");
                }
            }
        }

        public Student(string fullname, string groupNo, byte age)
        {
            Id = studentCount++;
            Fullname = fullname;
            GroupNo = groupNo;
            _age = age;

        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 4)
            {
                return false;
            }

            char firstChar = groupNo[0];
            string digits = groupNo.Substring(1);

            if (char.IsLetter(firstChar) && digits.Length == 3 && int.TryParse(digits, out int number))
            {
                return true;
            }

            return false;
        }

        public static bool CheckFullname(string fullname) 
        {
            int spaceIndex = -1;

            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }

            if (spaceIndex <= 0 || spaceIndex >= fullname.Length - 1)
            {
                return false;
            }

            return true;
        }  

    }
}
