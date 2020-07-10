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

namespace CookTime
{
    [Activity(Label = "Recipe")]
    public class ShareRecipeActivity : Activity
    {

        Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ShareRecipeLayout);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetActionBar(toolbar);

            // Create your application here
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
                    var intent = new Intent(this, typeof(newFeed));
                    StartActivity(intent);
                    break;
                case Resource.Id.ic_recomendations:
                    var intent2 = new Intent(this, typeof(RecomendationsActivity));
                    StartActivity(intent2);
                    break;
                case Resource.Id.ic_notifications:
                    var intent1 = new Intent(this, typeof(NotificationsActivity));
                    StartActivity(intent1);
                    break;
                case Resource.Id.ic_profile:
                    var intent3 = new Intent(this, typeof(ProfileActivity));
                    StartActivity(intent3);
                    break;
                case Resource.Id.ic_add:
                    var intent4 = new Intent(this, typeof(ShareRecipeActivity));
                    StartActivity(intent4);
                    break;


            }
            return base.OnOptionsItemSelected(item);
        }

    }
}