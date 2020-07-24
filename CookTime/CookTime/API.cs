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

        public string connect(string request, string UserName, string Password)
        {
            webClient.QueryString.Add("UserName", UserName);
            webClient.QueryString.Add("Password", Password);
            string result = webClient.DownloadString("http://192.168.8.102:9080/" + request);
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

            String result = webClient.DownloadString("http://192.168.8.102:9080/" + request);
            Console.Write("HOLA"+result);
            return result;
        }


    }
}