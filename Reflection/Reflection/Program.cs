using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Rufat", 30);

            Type userType = user.GetType();
            FieldInfo idField = userType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo nameField = userType.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo ageField = userType.GetField("age", BindingFlags.NonPublic | BindingFlags.Static);

            idField.SetValue(user, 2);
            nameField.SetValue(user, "Rufat");
            ageField.SetValue(user, 35);

            Console.WriteLine("ID: " + user.GetType().GetField("id", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(user));
            Console.WriteLine("Name: " + user.GetType().GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(user));
            Console.WriteLine("Age: " + User.ChangeAge);
        }
    }
}