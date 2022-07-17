using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo.Services;

internal class MailService
{
    public void OnFoodPrepared(object source, EventArgs eventArgs)
    {
        Console.WriteLine("MailService: your food is prepared.");
        Console.WriteLine("Sending Email Confirmation...");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Email successfully sent");
        Console.WriteLine();
    }
}
