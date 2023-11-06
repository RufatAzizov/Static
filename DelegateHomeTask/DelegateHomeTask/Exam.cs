using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeTask
{
    public class Exam
    {

        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Point { get; set; }
        public int Duration { get; set; }
        public string Date { get; }

        public Exam(string studentName, string subject, int point, int duration, string date)
        {
            StudentName = studentName;
            Subject = subject;
            Point = point;
            Duration = duration;
            Date = date;
        }

    }


    

    
}
