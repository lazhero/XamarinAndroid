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
    [Activity(Label = "ProfileActivity")]
    public class ProfileActivity : Activity
    {

        ListView list_myMenu;
        string username = SingInActivity.getusername;



        Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Profile);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);

            TextView txt_userName = FindViewById<TextView>(Resource.Id.textView2);


            Button buttonFollowing = FindViewById<Button>(Resource.Id.buttonFollowing);
            buttonFollowing.Click += ButtonFollowing_Click;

            Button buttonFollowers = FindViewById<Button>(Resource.Id.buttonFollowers);
            buttonFollowers.Click += ButtonFollowers_Click;

            Button buttonAdmin = FindViewById<Button>(Resource.Id.buttonadministration);
            buttonAdmin.Click += ButtonAdmin_Click;

            Button btn_difficulty = FindViewById<Button>(Resource.Id.btn_difficulty);
            btn_difficulty.Click += buttonDifficulty_Click;

            Button btn_date = FindViewById<Button>(Resource.Id.btn_date);
            btn_date.Click += buttonDate_Click;

            Button btn_punctuation = FindViewById<Button>(Resource.Id.btn_punctuation);
            btn_punctuation.Click += buttonPunctuation_Click;

        }

        private void buttonPunctuation_Click(object sender, EventArgs e)
        {
            callSort("1");
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            callSort("2");
        }

        private void buttonDifficulty_Click(object sender, EventArgs e)
        {
            callSort("3");
        }

        private void callSort(string sortType)
        {
            API sortAPI = new API();
            string jsonSort = sortAPI.connectSort("MyMenu", sortType, username);

            Console.WriteLine("sortType desde perfil: " + sortType);
            Console.WriteLine("username desde perfil: " + username);
            Console.WriteLine("Json string desde Profile: " + jsonSort);


            List<Recipe> myRecipes = JsonConvert.DeserializeObject<List<Recipe>>(jsonSort);


            list_myMenu = FindViewById<ListView>(Resource.Id.list_myMenu);

            List<string> list_myRecipe = new List<string>();

            foreach (var recipe in myRecipes)
                list_myRecipe.Add(recipe.RecipeName);

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list_myRecipe);
            list_myMenu.Adapter = adapter;

            list_myMenu.ItemClick += (s, e) =>
            {
                toPost(e.Position);
            };

        }


        private void toPost(int RecipePosition)
        {
            Intent intent = new Intent(this, typeof(PostActivity));
            intent.PutExtra("RecipePosition", RecipePosition);// se envia la posicion del nombre de la receta a la siguiente actividad
            StartActivity(intent);
            Finish();
        }





        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(administration));
          
            
        }

        private void ButtonFollowing_Click(object sender, EventArgs e)
        {
            var intent1 = new Intent(this, typeof(FollowingActivity));
            StartActivity(intent1);
            
        }

        private void ButtonFollowers_Click(object sender, EventArgs e)
        {
            var intent2 = new Intent(this, typeof(FollowersActivity));
            StartActivity(intent2);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.navigation, menu);
            return base.OnCreateOptionsMenu(menu);
        }



        private void CreateCompany()
        {
            API api = new API();
            string Ap = api.connecta("Company", "unaa", "2", "2", "2", "2",  "a");
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
    }
}