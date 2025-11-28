using AirLineEfCore02.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AirLineEfCore02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new MainDbContext();



            //================= Section A (Loading data) ================================

            #region Question01
            ////Load "EgyptAir" With all its aircrafts and their routes  
            //var egyptair = context.Airlines
            //    .Where(s => s.Name == "EgyptAir")
            //    .Include(a => a.aircrafts)
            //    .ThenInclude(c => c.assigned)
            //    .ThenInclude(ac => ac.routes)
            //    .FirstOrDefault();
            //if (egyptair == null)
            //{
            //    Console.WriteLine("EgyptAir not found.");
            //    return;
            //}
            //Console.WriteLine($"Airline: {egyptair.Name}");
            //foreach (var aircraft in egyptair.aircrafts)
            //{
            //    Console.WriteLine($"\nAircraft ID: {aircraft.Id}, Model: {aircraft.Model}");
            //    if (aircraft.assigned.Count == 0)
            //    {
            //        Console.WriteLine("  No routes assigned.");
            //        continue;
            //    }
            //    foreach (var assignment in aircraft.assigned)
            //    {
            //        var route = assignment.routes;
            //        Console.WriteLine($"  Route ID: {route.Id}, From: {route.Origin} To: {route.Destination}, Distance: {route.Distance} km");
            //    }
            //}
            #endregion

            #region Question02                        //with problem
            ////Retrieve all airlines with their employees, and for each employee load their qualifications. 
            //var allairlines = context.Airlines
            //    .Include(c => c.Employees)
            //    .ThenInclude(f => f.Qualifications)
            //    .FirstOrDefault();

            #endregion

            #region Question03
            ////Load all airlines with their transactions, but only include transactions where Amount > 10000 
            //var airlineswithrelated = context.Airlines
            //    .Include(a => a.transactions.Where(t => t.Amount > 10000))
            //    .ToList();
            //foreach (var transaction in airlineswithrelated) {
            //    Console.WriteLine($"{transaction.Id} : {transaction.Name}");
            //}


            #endregion

            #region Question04                    //VIP
            ////Select all routes along with the model of aircrafts assigned to them 
            //var routesWithAircrafts = context.Routes
            //  .Select(r => new
            //  {
            //      r.Id,
            //      r.Origin,
            //      r.Destination,
            //      AircraftModels = r.assigneds
            //          .Select(a => a.aircraft.Model)
            //          .ToList()
            //  })
            //  .ToList();
            //foreach (var route in routesWithAircrafts)
            //{
            //    Console.WriteLine($"Route ID: {route.Id}, From: {route.Origin} To: {route.Destination}");
            //    Console.WriteLine("  Aircrafts assigned:");

            //    if (route.AircraftModels.Count == 0)
            //    {
            //        Console.WriteLine("    None");
            //    }
            //    else
            //    {
            //        foreach (var model in route.AircraftModels)
            //        {
            //            Console.WriteLine("    " + model);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Qestion05
            ////Retrieve all aircrafts with their airline and the airline’s phones.
            //var data=context.Aircrafts
            //    .Include(c=>c.airline)
            //    .ThenInclude(f=>f.Phones)
            //    .ToList();

            //foreach (var ac in data)
            //{
            //    Console.WriteLine($"Aircraft ID: {ac.Id}, Model: {ac.Model}, Airline: {ac.airline.Name}");
            //    if (ac.airline.Phones != null && ac.airline.Phones.Count > 0)
            //    {
            //        Console.WriteLine("  Phones:");
            //        foreach (var phone in ac.airline.Phones)
            //        {
            //            Console.WriteLine("    " + phone.Phone);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("  No phones found.");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            //===================== Section B : Join Operators  ======================
            #region Question01
            ////List all employees with their airline name
            //var list = from e in context.Employees
            //           join a in context.Airlines
            //           on e.AirlineId equals a.Id
            //           select new
            //           {
            //              EmployeeName =e.Name,
            //              AirlneName= a.Name
            //           };

            //foreach (var item in list) {
            //    Console.WriteLine($"{item.EmployeeName} : {item.AirlneName}");

            //}
            #endregion

            #region Question02
            ////Show all routes with the aircraft model assigned and the airline name that owns the aircraft. 
            //var routesinfo = from r in context.Routes
            //                 join asg in context.Assigneds on r.Id equals asg.RouteId
            //                 join ac in context.Aircrafts on asg.AircraftId equals ac.Id
            //                 join al in context.Airlines on ac.AirlineId equals al.Id
            //                 select new
            //                 {
            //                     RouteOrigin = r.Origin,
            //                     RouteDistination = r.Destination,
            //                     AircraftModel = ac.Model,
            //                     AirlineName = al.Name
            //                 };

            //foreach (var route in routesinfo) {
            //    Console.WriteLine($"Route:{route.RouteOrigin} ==> {route.RouteDistination} ,Aircraft : {route.AircraftModel} , Airline: {route.AirlineName}");
            //}
            #endregion

            #region Question03
            ////For each airline, list its aircraft models. 
            //var models = from a in context.Airlines
            //             join ac in context.Aircrafts
            //             on a.Id equals ac.AirlineId
            //             select new
            //             {
            //                 AirlineName = a.Name,
            //                 AircraftModel = ac.Model
            //             };
            //foreach (var model in models) {
            //    Console.WriteLine($"{model.AirlineName} : {model.AircraftModel}");
            //}
            #endregion

            #region Questin04
            ////Show all transactions (id, amount, description) along with the airline name, but only where Amount > 20000.
            //var trans = from tr in context.Transactions
            //            where tr.Amount > 200000
            //            join ai in context.Airlines
            //            on tr.AirlineId equals ai.Id
            //            select new
            //            {
            //                TransactionId = tr.Id,
            //                TransactionDisc = tr.Description,
            //                TransactionAmount = tr.Amount,
            //                AirlineName = ai.Name
            //            };

            //foreach (var item in trans) {
            //    Console.WriteLine($"{item.AirlineName} ==> {item.TransactionId} , {item.TransactionDisc} , {item.TransactionAmount}");
            //}
            #endregion

        }
    }
}
