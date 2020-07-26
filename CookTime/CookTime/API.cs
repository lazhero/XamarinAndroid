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
        private string site = "http://192.168.8.102:9080/";

        public string connect(string request, string UserName, string Password)
        {
            webClient.QueryString.Add("UserName", UserName);
            webClient.QueryString.Add("Password", Password);
            string result = webClient.DownloadString(site + request);
            return result;
        }

        public string connectSort(string request, string Sort, string UserName)
        {
            webClient.QueryString.Add("SortState", Sort);
            webClient.QueryString.Add("UserName", UserName);
            string result = webClient.DownloadString(site + request);
            return result;
        }

        public string connect(string request, string UserName)
        {
            webClient.QueryString.Add("UserName", UserName);
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

        public string connect(string request, string Author, string RecipeName, string RecipeKind, string RecipeRoll, string RecipeTime, string DietType, string portions, string Steps, string Ingredients, string Amount, string Difficulty)
        {
            Console.Write("iniciamos");
            Console.WriteLine(Author);
            Console.WriteLine(RecipeName);


            webClient.QueryString.Add("Author", Author);
            webClient.QueryString.Add("RecipeName", RecipeName);
            webClient.QueryString.Add("RecipeKind", RecipeKind);
            webClient.QueryString.Add("RecipeRoll", RecipeRoll);
            webClient.QueryString.Add("RecipeTime", RecipeTime);
            // string xd = "DietType[0";
            // for (int i = 0; i < DietType.Size(); i++) {
            //     webClient.QueryString.Add(xd + i.ToString() + "]", (string)DietType.Get(i));            
            // }
            webClient.QueryString.Add("DietType", DietType);
            webClient.QueryString.Add("Steps", Steps);
            webClient.QueryString.Add("portions", portions);
            webClient.QueryString.Add("Ingredients", Ingredients);
            webClient.QueryString.Add("Amount", Amount);
            webClient.QueryString.Add("Difficulty", Difficulty);


            //Console.WriteLine("XDDDD"+(string)DietType.Get(0));
            // Console.WriteLine("XDDDD" + (string)DietType.Get(1));
            String result = webClient.DownloadString(site + request);
            Console.Write("HOLA" + result);
            return result;
        }
        public string connecta(string request, string CompanyName, string InitHour , string InitMinute, string FinalHour, string FinalMinute,string UserName)
        {


            webClient.QueryString.Add("CompanyName", CompanyName);
            webClient.QueryString.Add("InitHour", InitHour);
            webClient.QueryString.Add("InitMinute", InitMinute);
            webClient.QueryString.Add("FinalHour", FinalHour);
            webClient.QueryString.Add("FinalMinute", FinalMinute);
            webClient.QueryString.Add("UserName", UserName);

            Console.WriteLine();

            String result = webClient.DownloadString(site + request);
            Console.Write("HOLA" + result);
            return result;
        }


    }
}