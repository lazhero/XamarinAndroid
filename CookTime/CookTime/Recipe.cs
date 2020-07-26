using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
using Newtonsoft.Json.Linq;

namespace CookTime
{
    public class Recipe
    {
        public List<string> subscribers { get; set; }
        public int id { get; set; }
        public String RecipeName { get; set; }
        public String Author { get; set; }
        public int portions { get; set; }
        public int amount { get; set; }
        public List<string> Tags { get; set; }
        public List<Comment> comment { get; set; }
        public double grade { get; set; }
        public int reviewNumber { get; set; }
        public List<string> Steps { get; set; }
        public List<string> IngredientList { get; set; }
        public int difficulty { get; set; }
        public string date { get; set; }
        public int comparingState { get; set; }



    }
}