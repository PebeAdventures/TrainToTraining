using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasks
{
    public class ListDrawer
    {

        public void Draw(List<string> list, long start)
        {
            long i = start;
            foreach (var item in list)
            {

                Console.WriteLine(i + ": " + item);
                i++;
            }
        }

    }
}
