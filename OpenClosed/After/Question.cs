using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After
{
    public abstract class Question
    {
        public string Title { get; set; }
        public int Mark { get; set; }
        public abstract void Print();
    }
}
