using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasks.Fibonacci
{
    public class FibonacciRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine("Podaj początek ciągu >=0, <=49");

            long start = long.Parse(Console.ReadLine());
            if (!start.GreaterThenZero() || !start.UpperThen50())
            {
                throw new IndexOutOfRangeException("Parameter index is out of range. " + start);
            }

            Console.WriteLine("Podaj koniec ciągu >niż początek, <=50");
            long end = long.Parse(Console.ReadLine());
            if (end.GreaterThenScopeStart(start))
            {
                throw new IndexOutOfRangeException("Parameter index is out of range. " + start);
            }
            ScopeOfCalculation scope = new()
            {
                Start = start,
                End = end
            };
            List<string> outputList = new FibonacciSequenceCreator().Calculate(scope);
            new ListDrawer().Draw(outputList, scope.Start);
        }


    }
}
