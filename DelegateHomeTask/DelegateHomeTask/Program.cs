namespace DelegateHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            byte input;
            do
            {

                Console.WriteLine("1. Add exam");
                Console.WriteLine("2. Show passed exams");
                Console.WriteLine("3. Show exams with duration more than 1 hour");
                Console.WriteLine("0. Exit");
                input = Convert.ToByte(Console.ReadLine());

                switch (input)
                {
                    case 1:


                        Console.WriteLine("Student name: ");
                        string studentName = Console.ReadLine();


                        Console.WriteLine("Subject name: ");
                        string subject = Console.ReadLine();

                        Console.WriteLine("Student's score: ");
                        int point = int.Parse(Console.ReadLine());

                        Console.WriteLine("Duration (in hours): ");
                        int duration = int.Parse(Console.ReadLine());

                        Console.WriteLine("Date: ");
                        string date = Console.ReadLine();

                        exams.Add(new Exam(studentName, subject, point, duration, date));

                        break;
                    case 2:
                        List<Exam> highScoringExams = exams.Where(e => e.Point > 50).ToList();
                        Console.WriteLine("List of passed students");
                        PrintExams(highScoringExams);
                        break;

                    case 3:
                        List<Exam> longExams = exams.Where(e => e.Duration >= 1).ToList();
                        Console.WriteLine("Exams with duration more than an hour:");
                        PrintExams(longExams);
                        break;

                }  
            } while (input != 0);

        }

        static void PrintExams(List<Exam> exams)
        {
            foreach (var exam in exams)
            {
                Console.WriteLine($"StudentName: {exam.StudentName}, Subject: {exam.Subject}, Point: {exam.Point}, Duration: {exam.Duration} hours");
            }
        }
    }
}