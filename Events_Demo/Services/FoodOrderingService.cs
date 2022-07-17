using Events_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo;

internal class FoodOrderingService
{
    
    public delegate void FoodPreparedEventHandler(object source, EventArgs args); // define a delegate
 
    public event FoodPreparedEventHandler FoodPrepared; // declare the event

    public void PrepareOrder(Order order)
    {
        Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
        Thread.Sleep(4000);
        Console.WriteLine();
        OnFoodPrepared();
    }

    protected virtual void OnFoodPrepared()
    {
        FoodPrepared?.Invoke(this, EventArgs.Empty);
    }
}
