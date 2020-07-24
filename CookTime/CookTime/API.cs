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
            string result = webClient.DownloadString("http://192.168.1.7:9080/" + request);
            return result;
        }

        public string connect(string request, string FirstName, string LastName, string UserName, string Password,int Age)
        {
            webClient.QueryString.Add("UserName", UserName);
            webClient.QueryString.Add("Password", Password);
            string result = webClient.DownloadString("http://192.168.1.7:9080/" + request);
            return result;
        }
    }
}