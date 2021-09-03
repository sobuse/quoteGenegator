using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.Models
{
    public class Quotes
    {

        public string getQuote()
        {
            string[] quotes = new[] { "The purpose of our lives is to be happy.” — Dalai Lama",
                " Life is what happens when you're busy making other plans.” — John Lennon",
            "Get busy living or get busy dying.” — Stephen King.",
            "Never let the fear of striking out keep you from playing the game.”– Babe Ruth",
            "“Money and success don’t change people; they merely amplify what is already there.” — Will Smith",
            "“Your time is limited, so don’t waste it living someone else’s life. Don’t be trapped by dogma – which is living with the results of other people’s thinking.” – Steve Jobs"
            ,
            "Not how long, but how well you have lived is the main thing.” — Seneca",
            "If life were predictable it would cease to be life, and be without flavor.” – Eleanor Roosevelt",
            "The whole secret of a successful life is to find out what is one’s destiny to do, and then do it.”– Henry Ford",
            "The big lesson in life, baby, is never be scared of anyone or anything.”– Frank Sinatra"};

            var randomGen = new Random();
            var randomIndex = randomGen.Next(0, quotes.Length - 1);
            return quotes[randomIndex];
        }

         
        


    }
        
 }
       
      
    



