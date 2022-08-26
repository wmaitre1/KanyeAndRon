﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeAndRon
{
    public  class RonAngKanyeQuoteGen
    {
        public static void KanyeQuote()
        {

            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"_________________________");

            Console.WriteLine($"Kanye:  {kanyeQuote}");

            Console.WriteLine($"__________________________");
        }


        public static void RonQuote()
        { 
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"_________________________");

            Console.WriteLine($"Ron:  {ronQuote}");

            Console.WriteLine($"_________________________");

            Console.ReadLine();
        }

        
       
       
    }
}
