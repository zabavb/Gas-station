using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_lesson_csh_wf
{
    public class Food
    {
        public string Name { get; set; }
        public float Multiplication { get; set; }

        public Food(string name, float multiplication)
        {
            Name = name;
            Multiplication = multiplication;
        }
    }
}
