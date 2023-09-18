using System.Diagnostics;

Console.Write("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b:");
int b = int.Parse(Console.ReadLine());
Thread.CurrentThread.Name = "main";
NOD();
Thread mythread = new Thread(NOD);
mythread.Name = "back";
mythread.Start();
void NOD()
{
    Console.WriteLine();
    Console.WriteLine(Thread.CurrentThread.Name + " начал работу...");
    int nod;
    int nok;
    Stopwatch stpwatch = new Stopwatch();
    stpwatch.Start();
    while (a != b)
    {
        if(a > b)
        {
            a = a - b;
        }
        else
        {
            b = b -a;
        }
    }
    nod = b;
    nok = a * b / nod;
    Console.WriteLine("НОК: " + nok);
    stpwatch.Stop();
    Console.WriteLine("StopWatch: " + stpwatch.ElapsedTicks.ToString());
    Console.WriteLine(Thread.CurrentThread.Name + " закончил работу...");
}