using System;
using System.Threading;

Console.WriteLine("Press 'R' to reset or Press 'Q' to quit ");
static void UpdateTimer()
{
    bool running = true;
    int seconds = 0;
    object lockObject = new object();
    while (running)
    {
        lock (lockObject)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write($"Time passed: {seconds} seconds     ");
            seconds++;
        }
        Thread.Sleep(1000);
    }
}
static void ListenForInput()
{
    bool running = true;
    int seconds = 0;
    object lockObject = new object();
    while (running)
    {
        var key = Console.ReadKey(true).Key;
        lock (lockObject)
        {
            if (key == ConsoleKey.R)
            {
                seconds = 0;
                Console.Clear();
            }
            else if (key == ConsoleKey.Q)
            {
                running = false;
                Console.Clear();
                Console.WriteLine("Program terminated.");
            }
        }
    }
}

Thread timerThread = new Thread(UpdateTimer);
Thread inputThread = new Thread(ListenForInput);

timerThread.Start();
inputThread.Start();

timerThread.Join();
inputThread.Join();