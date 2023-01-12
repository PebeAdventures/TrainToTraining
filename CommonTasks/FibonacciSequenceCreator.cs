using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasks
{
    public class FibonacciSequenceCreator
    {

        public List<string> Calculate(ScopeOfCalculation scopeOfCalculation)
        {
            List<string> outputList = CalculateFibonacci(scopeOfCalculation.Start, scopeOfCalculation.End);

            return outputList;
        }

        private List<string> CalculateFibonacci(long start, long stop)
        {
            var fibboList = new Dictionary<long, long>
            {
                { 1, 1 },
                { 2, 1 }
            };

            for (int i = 3; i <= stop; i++)
            {

                fibboList.Add(i, fibboList[i - 1] + fibboList[i - 2]);
            }

            List<string> outputList = PrepareTheScope(fibboList, start);
            return outputList;
        }

        private List<string> PrepareTheScope(Dictionary<long, long> fibboList, long start)
        {
            List<string> output = new List<string>();
            output = fibboList.Where(x => x.Key >= start).Select(x => x.Value.ToString()).ToList();

            return output;
        }
    }
}
