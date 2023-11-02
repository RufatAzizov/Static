using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class User
    {
        private int id;
        private string name;
        private static int age;

        public User(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            User.age = age;
        }

        public static void ChangeAge(int newAge)
        {
            age = newAge;
        }
    }
}
