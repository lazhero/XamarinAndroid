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
using Newtonsoft.Json;

namespace CookTime
{
    [Activity(Label = "PostActivity")]
    public class PostActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PostLayout);

            String userName = Intent.Extras.GetString("UserName");
            int rp = Intent.Extras.GetInt("RecipePosition"); // rp: posicion de la receta en la lista de recetas, lo utilizamos para encontrar la recta a la que se dio click


            API newsfeedAPI = new API();
            string jsonRecipes = newsfeedAPI.connect("NewsFed", userName);
            List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(jsonRecipes);// creamos una lista de recetas traida desde el servidor

            

            TextView txt_recipeName = FindViewById<TextView>(Resource.Id.txt_recipeName);
            txt_recipeName.Text += recipes[rp].RecipeName;

            TextView txt_authorName = FindViewById<TextView>(Resource.Id.txt_authorName);
            txt_authorName.Text += recipes[rp].Author;

            TextView txt_dishType = FindViewById<TextView>(Resource.Id.txt_dishType);
            //txt_dishType.Text += recipes[rp].Tags;

            TextView txt_portions = FindViewById<TextView>(Resource.Id.txt_authorName);
            txt_portions.Text += recipes[rp].portions;

            TextView txt_preparationTime = FindViewById<TextView>(Resource.Id.txt_preparationTime);
            //txt_preparationTime.Text += recipes[rp].pr;

            TextView txt_course = FindViewById<TextView>(Resource.Id.txt_course);
            //txt_course.Text += recipes[rp].;

            TextView txt_difficulty = FindViewById<TextView>(Resource.Id.txt_difficulty);
            txt_difficulty.Text += recipes[rp].difficulty;

            TextView txt_tags = FindViewById<TextView>(Resource.Id.txt_tags);
            foreach (var tag in recipes[rp].Tags)
                txt_tags.Text += recipes[rp].Tags + ", ";

            TextView txt_ingredients = FindViewById<TextView>(Resource.Id.txt_ingredients);
            foreach (var ingredient in recipes[rp].IngredientList)
                txt_ingredients.Text += ingredient + ", ";
            //txt_ingredients.Text += recipes[rp].IngredientList;

            TextView txt_steps = FindViewById<TextView>(Resource.Id.txt_steps);
            foreach (var step in recipes[rp].Steps)
                txt_steps.Text += step + ", ";
            //txt_steps.Text += recipes[rp].Steps;

            TextView txt_price = FindViewById<TextView>(Resource.Id.txt_price);
            txt_price.Text += recipes[rp].amount;



        }




    }
}