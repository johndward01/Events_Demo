using Events_Demo;
using Events_Demo.Models;
using Events_Demo.Services;

var order = new Order { Item = "Pizza with extra cheese" };

var orderingService = new FoodOrderingService();
var appService = new AppService();
var mailService = new MailService();

orderingService.FoodPrepared += appService.OnFoodPrepared;
orderingService.FoodPrepared += mailService.OnFoodPrepared;

orderingService.PrepareOrder(order);