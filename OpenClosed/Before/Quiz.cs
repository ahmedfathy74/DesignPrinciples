using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Before
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
                Console.WriteLine($"{q.Title} [{q.Mark}]");
                switch(q.QuestionType)
                {
                    case QuestionType.WH:
                        Console.WriteLine("  _____________________________");
                        Console.WriteLine("  _____________________________");
                        Console.WriteLine("  _____________________________");
                        break;
                    case QuestionType.TRUEFALSE:
                        Console.WriteLine("  1. T");
                        Console.WriteLine("  2. F");
                        break;
                    case QuestionType.MULTIPLECHOICE:
                        foreach (var choice in q.Choices)
                        {
                            Console.WriteLine($"  {choice}");
                        }
                        break;
                    default: break;
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
