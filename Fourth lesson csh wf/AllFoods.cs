using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_lesson_csh_wf
{
    public class AllFoods
    {
        public float Sum { get; set; }
        public List<Food> Foods { get; set; }

        public AllFoods()
        {
            Foods = new List<Food>();
        }

        public void Delete(string name)
        {
            for (int i = 0; i < Foods.Count; i++)
                if (Foods[i].Name == name)
                    Foods.RemoveAt(i);
        }

        public override string ToString()
        {
            Sum = 0;
            for (int i = 0; i < Foods.Count; i++)
                Sum += Foods[i].Multiplication;
            return Sum.ToString();
        }
    }
}
