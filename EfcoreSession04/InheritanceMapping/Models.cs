using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    internal class Models
    {
            // Q1
            public class Vehicle
            {
                public int Id { get; set; }
                public string Model { get; set; }
                public int Speed { get; set; }
            }

            public class Car : Vehicle
            {
                public int NumberOfDoors { get; set; }
            }

            public class Bus : Vehicle
            {
                public int Capacity { get; set; }
            }


            //Q2
            public class Payment
            {
                public int Id { get; set; }
                public int Amount { get; set; }
            }

            public class CreditCardPayment : Payment
            {
                public int CardNumber { get; set; }
            }

            public class CashPayment : Payment
            {
                public string Currency { get; set; }
            }

            //Q3
            public class Product
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

            public class Book : Product
            {
                public string Author { get; set; }
            }

        public class Electronics : Product
        {
            public string Prand { get; set; }
        
          }
        }
}
