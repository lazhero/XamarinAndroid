﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CookTime
{
    [Activity(Label = "Recipe")]
    public class ShareRecipeActivity : Activity
    {

        Toolbar toolbar;
        private static string TypeRecipe = "";
        private static string TimeRecipe = "";
        private static string RollRecipe = "";
        private static string DietType = "";


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ShareRecipeLayout);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);


            //Buttons
            Button BreakFastB = FindViewById<Button>(Resource.Id.buttonBreakfast);
            BreakFastB.Click += BreakFastB_Click;

            Button DinnerB = FindViewById<Button>(Resource.Id.buttonDinner);
            DinnerB.Click += DinnerB_Click;

            Button LunchB = FindViewById<Button>(Resource.Id.buttonLunch);
            LunchB.Click += LunchB_Click;

            Button SnackB = FindViewById<Button>(Resource.Id.buttonSnack);
            SnackB.Click += SnackB_Click;

            Button BrunchB = FindViewById<Button>(Resource.Id.buttonBrunch);
            BrunchB.Click += BrunchB_Click;

            Button ShortTimeB = FindViewById<Button>(Resource.Id.buttonShortTime);
            ShortTimeB.Click += ShortTimeB_Click;

            Button MiddleTimeB = FindViewById<Button>(Resource.Id.buttonMiddleTime);
            MiddleTimeB.Click += MiddleTimeB_Click;

            Button LongTimeB = FindViewById<Button>(Resource.Id.buttonLongTime);
            LongTimeB.Click += LongTimeB_Click;

            Button LongerTimeB = FindViewById<Button>(Resource.Id.buttonLongerTime);
            LongerTimeB.Click += LongerTimeB_Click;

            Button AppetizerB = FindViewById<Button>(Resource.Id.buttonAppetizer);
            AppetizerB.Click += AppetizerB_Click;

            Button EntryB = FindViewById<Button>(Resource.Id.buttonEntry);
            EntryB.Click += EntryB_Click;

            Button MainCourseB = FindViewById<Button>(Resource.Id.buttonMainCourse);
            MainCourseB.Click += MainCourseB_Click;

            Button AlcoholicB = FindViewById<Button>(Resource.Id.buttonAlcoholic);
            AlcoholicB.Click += AlcoholicB_Click;

            Button ColdDrinkB = FindViewById<Button>(Resource.Id.buttonColdDrink);
            ColdDrinkB.Click += ColdDrinkB_Click;

            Button WarmDrinkB = FindViewById<Button>(Resource.Id.buttonWarmDrink);
            WarmDrinkB.Click += WarmDrinkB_Click;

            Button DesserB = FindViewById<Button>(Resource.Id.buttonDesert);
            DesserB.Click += DesserB_Click;

            Button VegetarianB = FindViewById<Button>(Resource.Id.buttonVegetarian);
            VegetarianB.Click += VegetarianB_Click;

            Button VeganB = FindViewById<Button>(Resource.Id.buttonVegan);
            VeganB.Click += VeganB_Click;

            Button KosherB = FindViewById<Button>(Resource.Id.buttonKosher);
            KosherB.Click += KosherB_Click;

            Button KetoB = FindViewById<Button>(Resource.Id.buttonKeto);
            KetoB.Click += KetoB_Click;

            Button CeliacB = FindViewById<Button>(Resource.Id.buttonCeliac);
            CeliacB.Click += CeliacB_Click;

            Button CarnivorousB = FindViewById<Button>(Resource.Id.buttonCarnivorous);
            CarnivorousB.Click += CarnivorousB_Click;


            Button BPost = FindViewById<Button>(Resource.Id.buttonPost);
            BPost.Click += BPost_Click;
            


            // Create your application here
        }

        private void BPost_Click(object sender, EventArgs e)
        {
            ShareRecipe();
        }

        private void CarnivorousB_Click(object sender, EventArgs e)
        {
            TypeOfDiet = "Carinovorous";
        }

        private void CeliacB_Click(object sender, EventArgs e)
        {
            TypeOfDiet = "Celiac";
        }

        private void KetoB_Click(object sender, EventArgs e)
        {
            TypeOfDiet = "Keto";
        }

        private void KosherB_Click(object sender, EventArgs e)
        {
            TypeOfDiet = "Kosher";
        }

        private void VeganB_Click(object sender, EventArgs e)
        {
            TypeOfDiet = "Vegan";
        }

        private void VegetarianB_Click(object sender, EventArgs e)
        {
            TypeOfDiet = "Cegetarian";
        }

        private void DesserB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "Dessert";

        }

        private void WarmDrinkB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "WarmDrink";
        }

        private void ColdDrinkB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "ColdDrink";
        }

        private void AlcoholicB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "AlcoholicDrink";
        }

        private void MainCourseB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "MainCourse";
        }

        private void EntryB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "Entry";
        }

        private void AppetizerB_Click(object sender, EventArgs e)
        {
            RollOfRecipe = "Appetizer";
        }

        private void LongerTimeB_Click(object sender, EventArgs e)
        {
            TimeOfRecipe = "LongetTime";
        }

        private void LongTimeB_Click(object sender, EventArgs e)
        {
            TimeOfRecipe = "LongTime";
        }

        private void MiddleTimeB_Click(object sender, EventArgs e)
        {
            TimeOfRecipe = "MiddleTime";
        }

        private void ShortTimeB_Click(object sender, EventArgs e)
        {
            TimeOfRecipe = "ShortTime";
        }

        private void BrunchB_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SnackB_Click(object sender, EventArgs e)
        {
            TypeOfRecipe = "Snack";
        }

        private void LunchB_Click(object sender, EventArgs e)
        {
            TypeOfRecipe = "Lunch";
        }
    

        private void DinnerB_Click(object sender, EventArgs e)
        {
            TypeOfRecipe = "Dinner";
        }

        private void BreakFastB_Click(object sender, EventArgs e)
        {
            TypeOfRecipe = "BreakFast";
        }

        private void ShareRecipe()
        {
            API api = new API();
            string[] arr = new string[2];
            arr[0] = "xd";
            arr[1] = "Keto";
            string Ap = api.connect("RecipeGetter", "a","a" ,"Lunch", "Entry","LongerTime",arr,arr,arr,"2","5");
        }



        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.navigation, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.ic_home:
                    StartActivity(typeof(newFeed));
                    Finish();
                    break;
                case Resource.Id.ic_recomendations:
                    StartActivity(typeof(RecomendationsActivity));
                    Finish();
                    break;
                case Resource.Id.ic_notifications:
                    StartActivity(typeof(NotificationsActivity));
                    Finish();
                    break;
                case Resource.Id.ic_profile:
                    StartActivity(typeof(ProfileActivity));
                    Finish();
                    break;
                case Resource.Id.ic_add:
                    StartActivity(typeof(ShareRecipeActivity));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
        public static string TypeOfRecipe
        {
            get { return TypeRecipe; }
            set { TypeRecipe = value; }
        }

        public static string TimeOfRecipe
        {
            get { return TimeRecipe; }
            set { TimeRecipe = value; }
        }

        public static string RollOfRecipe
        {
            get { return RollRecipe; }
            set { RollRecipe = value; }
        }
        public static string TypeOfDiet
        {
            get { return DietType; }
            set { DietType = value; }
        }
    }
}