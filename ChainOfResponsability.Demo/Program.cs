using ChainOfResponsability.Demo.Business;
using ChainOfResponsability.Demo.Business.Models;
using System;
using System.Globalization;

namespace ChainOfResponsability.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(
                "User name",
                "874500XX",
                new RegionInfo("DE"),
                new DateTimeOffset(1988, 1, 1, 00, 00, 00, TimeSpan.FromHours(2)));

            var processor = new UserProcessor();

            var result = processor.Register(user);

            Console.WriteLine(result);
        }
    }
}
