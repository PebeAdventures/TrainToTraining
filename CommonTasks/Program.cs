




using CommonTasks;

Console.WriteLine("Podaj początek ciągu");
long start = long.Parse(Console.ReadLine());
Console.WriteLine("Podaj koniec ciągu");
long end = long.Parse(Console.ReadLine()); ;
ScopeOfCalculation scope = new()
{
    Start = start,
    End = end
};
List<string> outputList = new FibonacciSequenceCreator().Calculate(scope);
new ListDrawer().Draw(outputList, scope.Start);


