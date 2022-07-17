using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo.Services;

internal class AppService
{
    public void OnFoodPrepared(object source, EventArgs eventArgs)
    {
        Console.WriteLine("AppService: your food is prepared.");
        Console.WriteLine("Starting the app services tasks...");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine("TASKS COMPLETED!");
        Console.WriteLine();
        Console.WriteLine();
    }
}
