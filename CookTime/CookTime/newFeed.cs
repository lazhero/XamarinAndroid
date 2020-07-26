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
using Newtonsoft.Json.Linq;

namespace CookTime
{
    [Activity(Label = "CookTime")]
    public class newFeed : Activity
    {

        ListView list_posts;
        string username = SingInActivity.getusername;


        Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.newFeed);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);

            API newsfeedAPI = new API();
            string jsonRecipes = newsfeedAPI.connect("NewsFed", username);


            List<Recipe> recipes = JsonConvert.DeserializeObject<List<Recipe>>(jsonRecipes);//Toma el json y lo transforma a objetos y crea una lista de objetos recetas.

            list_posts = FindViewById<ListView>(Resource.Id.list_posts);
            List<string> list_recipe = new List<string>();// Lista vacia con el fin de llenarla con el nombre de cada receta.

            foreach (var recipe in recipes)
                list_recipe.Add(recipe.RecipeName);//Se agrega el nombre de cada receta a la lista vacia List_recipe



            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list_recipe);// Adapta la informacion y la deja apta para un list view
            list_posts.Adapter = adapter;// Mete la info al list view

            list_posts.ItemClick += (s, e) => // lo que sucede al darle click a cada elemento del list view
            {
                toPost(e.Position);// llamamos a toPost y le enviamos la posicion del nombre de la receta que se dio click
            };


        }

        private void toPost(int RecipePosition)
        {
            Intent intent = new Intent(this, typeof(PostActivity));
            intent.PutExtra("RecipePosition", RecipePosition);// se envia la posicion del nombre de la receta a la siguiente actividad
            StartActivity(intent);
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
                    StartActivity(typeof(InitActivity));
                    Finish();
                    break;
                case Resource.Id.ic_recomendations:
                    StartActivity(typeof(RecomendationsActivity));
                    Finish();
                    break;
                case Resource.Id.ic_notifications:
                    Intent intent = new Intent();
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