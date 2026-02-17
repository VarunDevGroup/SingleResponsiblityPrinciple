// See https://aka.ms/new-console-template for more information
using SRPImplementation.Services;

OrderServices orderServices = new OrderServices();
orderServices.CreateOrder();

Console.ReadLine();