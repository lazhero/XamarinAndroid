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
        private static string tipodieta = "";
        private static string ingredients = "";
        private static string steps = "";


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ShareRecipeLayout);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);


            //Buttons

            Button BaddStep = FindViewById<Button>(Resource.Id.buttonaddSteps);
            BaddStep.Click += BaddStep_Click;
            Button BaddIngredients = FindViewById<Button>(Resource.Id.buttonIngredient);
            BaddIngredients.Click += BaddIngredients_Click;

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

            Button BPost = FindViewById<Button>(Resource.Id.buttonPost);
            BPost.Click += BPost_Click;

            // Create your application here
        }

        private void BaddIngredients_Click(object sender, EventArgs e)
        {

            EditText txt_ingredient = FindViewById<EditText>(Resource.Id.textIngredient);
            ingredients += txt_ingredient.Text + "/";
        }

        private void BaddStep_Click(object sender, EventArgs e)
        {
            EditText txt_step = FindViewById<EditText>(Resource.Id.textsteps);
            steps += txt_step.Text + "/";
        }

        private void BPost_Click(object sender, EventArgs e)
        {
            ShareRecipe();
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
            TimeOfRecipe = "LongerTime";
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
            TypeOfRecipe = "Brunch";
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
            TypeOfRecipe = "Breakfast";
        }

        private void ShareRecipe()
        {

            EditText txt_userName = FindViewById<EditText>(Resource.Id.textusername);
            EditText txt_RecipeName = FindViewById<EditText>(Resource.Id.textNameRecipe);
            EditText txt_portions = FindViewById<EditText>(Resource.Id.textPortions);
            EditText txt_difficulty = FindViewById<EditText>(Resource.Id.textdifficulty);
            EditText txt_amount = FindViewById<EditText>(Resource.Id.txtamount);

            API api = new API();
            CheckBox ch1 = FindViewById<CheckBox>(Resource.Id.checkBox1);
            CheckBox ch2 = FindViewById<CheckBox>(Resource.Id.checkBox2);
            CheckBox ch3 = FindViewById<CheckBox>(Resource.Id.checkBox3);
            CheckBox ch4 = FindViewById<CheckBox>(Resource.Id.checkBox4);
            CheckBox ch5 = FindViewById<CheckBox>(Resource.Id.checkBox5);
            CheckBox ch6 = FindViewById<CheckBox>(Resource.Id.checkBox6);

            if (ch1.Checked == true)
            {
                DietType += "Vegetarian/";
            }
            else
            {
            }
            if (ch2.Checked == true)
            {
                DietType += "Vegan/";
            }
            else
            {
            }
            if (ch3.Checked == true)
            {
                DietType += "Kosher/";
            }
            else
            {
            }
            if (ch4.Checked == true)
            {
                DietType += "Celiac/";
            }
            else
            {
            }
            if (ch5.Checked == true)
            {
                DietType += "Keto/";
            }
            else
            {
            }
            if (ch6.Checked == true)
            {
                DietType += "Carnivorous/";
            }
            else
            {
            }
            Console.WriteLine("odio" + DietType);

            string Ap = api.connect("RecipeGetter", txt_userName.Text, txt_RecipeName.Text, TypeOfRecipe, RollOfRecipe, TimeOfRecipe, DietType.Remove(DietType.Length - 1), txt_portions.Text, ingredients.Remove(ingredients.Length - 1), steps.Remove(steps.Length - 1), txt_amount.Text, txt_difficulty.Text);

            DietType = "";
            StartActivity(typeof(InitActivity));
            Finish();

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