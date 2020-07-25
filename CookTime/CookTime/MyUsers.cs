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
    public class MyUsers
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public string age { get; set; }
        public ProfileStructure profileStructure { get; set; }
        public List<string> follows { get; set; }
        public List<string> followers { get; set; }
    }
}