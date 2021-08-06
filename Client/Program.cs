using CoreLayer.Models;
using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client cli = new ServiceReference1.Service1Client();
            var result = cli.Read(new ServiceReference1.ReadRequest()).ReadResult; 
            foreach (var item in result)
                Console.WriteLine($"{item.ID} - {item.Nome}");

        }
    }
}
