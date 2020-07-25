using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CookTime
{
    class API
    {
        WebClient webClient = new WebClient();
        private string site = "http://192.168.1.7:9080/";

        public string connect(string request, string UserName, string Password)
        {
            webClient.QueryString.Add("UserName", UserName);
            webClient.QueryString.Add("Password", Password);
            string result = webClient.DownloadString(site + request);
            return result;
        }

        public string connect2(string request, string UserName, string Password, string FirstName, string LastName, string Age)
        {
            Console.Write("iniciamos");
            webClient.QueryString.Add("UserName", UserName);
            webClient.QueryString.Add("Password", Password);
            webClient.QueryString.Add("FirstName", FirstName);
            webClient.QueryString.Add("LastName", LastName);
            webClient.QueryString.Add("Age", Age);
            Console.WriteLine("BIENVENIDO " + FirstName);
            Console.WriteLine("BIENVENIDO " + LastName);
            Console.WriteLine("BIENVENIDO " + UserName);
            Console.WriteLine("BIENVENIDO " + Password);
            Console.WriteLine("BIENVENIDO " + Age);
            Console.WriteLine();

            String result = webClient.DownloadString(site + request);
            Console.Write("HOLA"+result);
            return result;
        }

        public string connect(string request, string Author, string RecipeName, string RecipeKind, string RecipeRoll, string RecipeTime,string[] DietType,string[] Steps, string[] Ingredients, string Amount,string Difficulty)
        {
            Console.Write("iniciamos");
            Console.WriteLine(Author);
            Console.WriteLine(RecipeName);
            //Console.WriteLine(Reci);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            webClient.QueryString.Add("Author", Author);
            webClient.QueryString.Add("RecipeName", RecipeName);
            webClient.QueryString.Add("RecipeKind", RecipeKind);
            webClient.QueryString.Add("RecipeRoll", RecipeRoll);
            webClient.QueryString.Add("RecipeTime", RecipeTime);
            webClient.QueryString.Add("DietType[0]", DietType[1]);
            webClient.QueryString.Add("Steps[0]", Steps[0]);
            webClient.QueryString.Add("Ingredients[0]", Ingredients[0]);
            webClient.QueryString.Add("Amount",Amount);
            webClient.QueryString.Add("Difficulty", Difficulty);

     
            Console.WriteLine();

            String result = webClient.DownloadString(site + request);
            Console.Write("HOLA" + result);
            return result;
        }



    }
}