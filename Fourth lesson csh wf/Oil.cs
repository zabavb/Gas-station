using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_lesson_csh_wf
{
    public class Oil
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
