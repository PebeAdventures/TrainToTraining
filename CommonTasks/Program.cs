




using CommonTasks;

Console.WriteLine("Podaj początek ciągu");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj koniec ciągu");
int end = Convert.ToInt32(Console.ReadLine());
ScopeOfCalculation scope = new()
{
    Start = start,
    End = end
};
List<string> outputList = new FibonacciSequenceCreator().Calculate(scope);
new ListDrawer().Draw(outputList, scope.Start);


