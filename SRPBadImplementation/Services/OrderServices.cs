using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPBadImplementation.Services
{
    internal class OrderServices
    {
        public void CreateOrder()
        {
            //Code to create order entity
            Console.WriteLine("Creatign Order");

            //Calling SaveData method from CreateOrder method 
            SaveData();

            //Calling SendMail method from CreateOrder method 

            SendMail();

            
        }

        public void SaveData()
        {
            //Code to save data to database
            Console.WriteLine("Saving data to database");
        }

        public void SendMail()
        {
            //Code to send email
            Console.WriteLine("Sending email");
        }
    }
}
