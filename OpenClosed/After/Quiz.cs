using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After
{
    public class Quiz
    {
        List<Question> Questions { get; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
        }

        public void Print()
        {
            foreach(var q in Questions)
            {
                q.Print();
                Console.WriteLine("\n\n");
            }
        }
    }
}
