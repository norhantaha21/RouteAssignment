using AirLineEfCore02.Models;
using System.ComponentModel.DataAnnotations;

namespace AirLineEfCore02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new MainDbContext();

            #region Question02-a
            //var airline = new Airline
            //{
            //    Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Address="Cairo" ,
            //    Phones = new List<Airline.AirlinePhone>
            //    {
            //        new Airline.AirlinePhone{Phone="0123456789"} ,
            //        new Airline.AirlinePhone{Phone="0111234567"}
            //    }
            //};
            //context.Airlines.Add(airline);
            //context.SaveChanges();

            #endregion

            #region Question02-b
            //var egyptAirId = context.Airlines
            //    .Where(a => a.Name == "EgyptAir")
            //    .Select(a => a.Id)
            //    .FirstOrDefault();


            //var aircraft = new Aircraft
            //{
            //    Model = "Model01",
            //    Capacity = 180,
            //    AirlineId = egyptAirId
            //};
            //context.Aircrafts.Add(aircraft);
            //context.SaveChanges();
            #endregion

            #region Question02-c
            //var egyptAirId = context.Airlines
            //    .Where(c => c.Name == "EgyptAir")
            //    .Select(a => a.Id)
            //    .FirstOrDefault();

            //var trans = new Transaction
            //{
            //    Amount=50000,
            //    Description="Tickets",
            //    AirlineId = egyptAirId,

            //};
            //context.Transactions.Add(trans);
            //context.SaveChanges();
            #endregion

            #region Question02-d
            //var egyptAirId = context.Airlines
            //    .Where(a => a.Name == "EgyptAir")
            //    .Select(a => a.Id)
            //    .FirstOrDefault();

            //var employees = context.Employees
            //.Where(a => a.AirlineId==egyptAirId)
            //.ToList();
            //Console.WriteLine(context.Employees.Count());
            #endregion

            #region Question02-e
            //var egyptAirId = context.Airlines
            //    .Where(a => a.Name == "EgyptAir")
            //    .Select(a => a.Id)
            //    .First();


            //var egyptAirTransaction = context.Transactions
            //    .Where(t => t.AirlineId==egyptAirId)
            //    .Select(t=> new
            //    {
            //        t.Id , t.Description , t.Amount
            //    }).ToList();
            //foreach (var t in egyptAirTransaction)
            //{
            //    Console.WriteLine($"ID: {t.Id} , Description: {t.Description} , Amount: {t.Amount}");
            //}
            #endregion

            #region Question02-f
            //var countEmployee = context.Employees
            //    .GroupBy(e => e.AirlineId)
            //    .Select(c => new
            //    {
            //        AirlineId = c.Key,
            //        TotalEmployees = c.Count()
            //    }).ToList();

            //foreach (var e in countEmployee)
            //{
            //    Console.WriteLine($"{e.AirlineId} : {e.TotalEmployees}");
            //}

            #endregion

            #region Question02-g
            //var ac = context.Aircrafts
            //.First(a => a.Model == "Model01");

            //ac.Capacity = 200;

            //context.SaveChanges();

            #endregion

            #region Question02-h
            //var oldtransaction = context.Transactions
            //    .Where(c => c.Date.Year < 2020)
            //    .ToList();
            //context.Transactions.RemoveRange(oldtransaction);
            //context.SaveChanges();
            #endregion

            #region Question02-i
            //var firstroute = new Route
            //{
            //    Origin = "Cairo",
            //    Destination = "Dubai",
            //    Classification = "International",
            //    Distance = 2400
            //};
            //context.Routes.Add(firstroute);
            //context.SaveChanges();
            #endregion

            #region Question02-j
        //      var model01Id = context.Aircrafts
        //.           Where(a => a.Model == "Model01")
        //           .Select(a => a.Id)
        //            .First();

        //        var cairoDubaiRouteId = context.Routes
        //            .Where(r => r.Origin == "Cairo" && r.Destination == "Dubai")
        //            .Select(r => r.Id)
        //            .First();

        //        var flight = new Assigned
        //        {
        //            AircraftId = model01Id,
        //            RouteId = cairoDubaiRouteId,
        //            DurationInMinutes = 4,
        //            Price = 3000
        //        };

        //        context.Assigneds.Add(flight);
        //        context.SaveChanges();
            #endregion
        }
    }
}
