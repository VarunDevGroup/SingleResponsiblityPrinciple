using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPImplementation.Services
{
    internal class OrderServices
    {
        private readonly DatabaseService _databaseService;
        private readonly EmailService _emailService;

        public OrderServices()
        {
            _databaseService = new DatabaseService();
            _emailService = new EmailService();
        }
        public void CreateOrder()
        {
            Console.WriteLine("Order created");

            _databaseService.Save();

            _emailService.Send();
        }
    }
}
