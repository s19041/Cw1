﻿using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            //var zmienna = "ala";


            //Console.WriteLine("Hello World!");
            //Console.WriteLine($"{zmienna} xd");

            //var newPerson = new Person {FirstName="Kajetan"};

            var url = "https://www.pja.edu.pl";

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var htmlContent = await response.Content.ReadAsStringAsync();

                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+",RegexOptions.IgnoreCase);

                var matches = regex.Matches(htmlContent);

                foreach (var match in matches)
                {

                    Console.WriteLine(match.ToString());

                }
            }

        }
    }
}
